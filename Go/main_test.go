package main

import (
	"reflect"
	"testing"
	"github.com/Coreyo-git/Leetcode-Problems/Go/problems"
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