package problems

// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

func TwoSum(nums []int, target int) []int {
	for i := 0; i < len(nums); i++ {
		for j := i + 1; j < len(nums); j++ {
			if nums[i] + nums[j] == target {
				arr := []int{i, j}
				return arr
			}
		}
	}

	return nil;
}

// Constraints:
//   2 <= nums.length <= 104
//   -109 <= nums[i] <= 109
//   -109 <= target <= 109
//   Only one valid answer exists.
