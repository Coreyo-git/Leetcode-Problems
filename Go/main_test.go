package main

import (
	"github.com/Coreyo-git/Leetcode-Problems/Go/problems"
	"reflect"
	"testing"
)

func TestTwoSum(t *testing.T) {
	tests := []struct {
		name   string
		nums   []int
		target int
		want   []int
	}{
		{
			name:   "Example 1",
			nums:   []int{2, 7, 11, 15},
			target: 9,
			want:   []int{0, 1},
		},
		{
			name:   "Example 2",
			nums:   []int{3, 2, 4},
			target: 6,
			want:   []int{1, 2},
		},
		{
			name:   "Example 3",
			nums:   []int{3, 3},
			target: 6,
			want:   []int{0, 1},
		},
		{
			name:   "Example 4",
			nums:   []int{2, 5, 5, 11},
			target: 10,
			want:   []int{1, 2},
		},
	}

	// Iterate over each test case defined in the 'tests' slice.
	for _, tt := range tests {
		// Run each test case as a subtest. This allows for clearer test output
		// and better organization, especially when a test function has multiple scenarios.
		t.Run(tt.name, func(t *testing.T) {
			// Call the TwoSum function from the problems package with the current test case's inputs.
			got := problems.TwoSum(tt.nums, tt.target)

			// Compare the actual result ('got') with the expected result ('tt.want').
			// reflect.DeepEqual is used for comparing slices (and other complex types) correctly.
			if !reflect.DeepEqual(got, tt.want) {
				// If the results do not match, report an error using t.Errorf.
				// This message includes the inputs and both the actual and expected outputs for debugging.
				t.Errorf("TwoSum(%v, %d) = %v, want %v", tt.nums, tt.target, got, tt.want)
			}
		})
	}
}

func TestPalindromeNumber(t *testing.T) {
	tests := []struct {
		name  string
		input int
		want  bool
	}{
		{
			name:  "Example 1",
			input: 121,
			want:  true,
		},
		{
			name:  "Example 2",
			input: -121,
			want:  false,
		},
		{
			name:  "Example 3",
			input: 10,
			want:  false,
		},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			got := problems.IsPalindrome(tt.input)
			if !reflect.DeepEqual(got, tt.want) {
				t.Errorf("IsPalindrome(%v) = %v, want %v", tt.input, got, tt.want)
			}
		})
	}

}

func TestMergeSortedArray(t *testing.T) {
	tests := []struct {
		name  string
		nums1 []int
		m     int
		nums2 []int
		n     int
		want  []int
	}{
		{
			name:  "Example 1",
			nums1: []int{1, 2, 3, 0, 0, 0},
			m:     3,
			nums2: []int{2, 5, 6},
			n:     3,
			want:  []int{1, 2, 2, 3, 5, 6},
		},
		{
			name:  "Example 2",
			nums1: []int{1},
			m:     1,
			nums2: []int{},
			n:     0,
			want:  []int{1},
		},
		{
			name:  "Example 3",
			nums1: []int{0},
			m:     0,
			nums2: []int{1},
			n:     1,
			want:  []int{1},
		},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			// Create a copy of nums1 to log in case of failure, as the function modifies it in-place.
			nums1Before := make([]int, len(tt.nums1))
			copy(nums1Before, tt.nums1)

			problems.MergeSortedArray(tt.nums1, tt.m, tt.nums2, tt.n)

			if !reflect.DeepEqual(tt.nums1, tt.want) {
				t.Errorf("MergeSortedArray(%v, %d, %v, %d) = %v, want %v", nums1Before, tt.m, tt.nums2, tt.n, tt.nums1, tt.want)
			}
		})
	}
}

func TestRemoveElement(t *testing.T) {
	tests := []struct {
		name string
		nums []int
		val  int
		want int
		expectedNums []int
	}{
		{
			name: "Example 1",
			nums: []int{3, 2, 2, 3},
			val:  3,
			want: 2,
			expectedNums: []int{2, 2},
		},
		{
			name: "Example 2",
			nums: []int{0, 1, 2, 2, 3, 0, 4, 2},
			val:  2,
			want: 5,
			expectedNums: []int{0, 0, 1, 3, 4},
		},
		{
			name: "Example 3",
			nums: []int{2},
			val:  3,
			want: 1,
			expectedNums: []int{2},
		},
	}

	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			gotVal, gotNums := problems.RemoveElement(tt.nums, tt.val)
			if !reflect.DeepEqual(gotVal, tt.want) {
				t.Errorf("RemoveElement(%v, %d) = %v, want %v", tt.nums, tt.val, gotVal, tt.want)
			}
			
			// Create new slice with all elements in range of want
			slicedNums := gotNums[0:tt.want]
			// sort elements to match test case
			for i := 0; i < tt.want; i++ {
				for j := i; j > 0 && slicedNums[j-1] > slicedNums[j]; j-- {
					slicedNums[j], slicedNums[j-1] = slicedNums[j-1], slicedNums[j]
				}
			}

			if !reflect.DeepEqual(slicedNums, tt.expectedNums) {
				t.Errorf("RemoveElement(%v, %d) = %v, want %v | Array was not mutated", tt.nums, tt.val, gotNums, tt.expectedNums)
			}
		})
	}
}
