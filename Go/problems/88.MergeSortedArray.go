package problems

// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

// Merge nums1 and nums2 into a single array sorted in non-decreasing order.

// The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

// works backwards from the end of nums1 to avoid needing extra space for a slice.
func MergeSortedArray(nums1 []int, m int, nums2 []int, n int) {
	if n == 0 {
		return
	}

	total := m + n
	temp :=  make([]int, total)
	nums1Pointer := 0
	nums2Pointer := 0

	for i := 0; i < total; i++ {
		if nums1Pointer >= m {
			temp[i] = nums2[nums2Pointer]
			nums2Pointer++
			continue
		} else if nums2Pointer >= n {
			temp[i] = nums1[nums1Pointer]
			nums1Pointer++
			continue
		}
		
		if nums1[nums1Pointer] < nums2[nums2Pointer] {
			temp[i] = nums1[nums1Pointer]
			nums1Pointer++
		} else if nums1[nums1Pointer] > nums2[nums2Pointer] {
			temp[i] = nums2[nums2Pointer]
			nums2Pointer++
		} else if nums1[nums1Pointer] == nums2[nums2Pointer] {
			temp[i] = nums1[nums1Pointer]
			i++
			temp[i] = nums1[nums1Pointer]
			nums1Pointer++
			nums2Pointer++
		}
	}
	copy(nums1, temp)
}

// Constraints:
// 	nums1.length == m + n
// 	nums2.length == n
// 	0 <= m, n <= 200
// 	1 <= m + n <= 200
// 	-109 <= nums1[i], nums2[j] <= 109
