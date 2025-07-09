package problems

// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

// Merge nums1 and nums2 into a single array sorted in non-decreasing order.

// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

// works backwards from the end of nums1 to avoid needing extra space for a slice.
func MergeSortedArray(nums1 []int, m int, nums2 []int, n int) {
	// If nums2 is empty, there's nothing to merge.
	if n == 0 {
		return
	}

	// last element in the initial part of nums1.
	p1 := m - 1
	// last element in nums2.
	p2 := n - 1

	// iterates backwards from the end of nums1.
	for i := m + n - 1; i >= 0; i-- {
		// If all elements from nums2 have been placed
		// break as nums1 is already sorted.
		if p2 < 0 {
			break
		}

		// If all elements from nums1 have been placed,
		// fill the rest of nums1 with nums2.
		if p1 < 0 {
			nums1[i] = nums2[p2]
			p2--
			continue
		}

		// Compare to find the larger one.
		// fill from left to right
		if nums1[p1] > nums2[p2] {
			nums1[i] = nums1[p1]
			p1-- // Move the pointer left.
		} else {
			nums1[i] = nums2[p2]
			p2--
		}
	}
}

// Constraints:
// 	nums1.length == m + n
// 	nums2.length == n
// 	0 <= m, n <= 200
// 	1 <= m + n <= 200
// 	-109 <= nums1[i], nums2[j] <= 109
