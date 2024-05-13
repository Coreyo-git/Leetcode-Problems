using System.Diagnostics;
using static Leetcode.TestUtils;

namespace Leetcode
{
	public class Solution
	{
		// Given an integer array nums, 
		// return true if there exists a triple of indices (i, j, k)
		// such that i < j < k and nums[i] < nums[j] < nums[k]. 
		// If no such indices exists, return false.
		public static bool IncreasingTriplet(int[] nums)
		{
			// Looping through each index [i] from 0
			// calculating if nums[i] < nums[i+1] and nums[i+1] < nums[i+2]
			// since we're looping through the indices in order we only need
			// to satisfy the condition of nums[i] < nums[j] < nums[k].
			for (int i = 0; i < nums.Length - 2; i++)
			{
				if(nums[i] < nums[i+1] && nums[i+1] < nums[i+2])
						return true;
			}
			return false;
		}

		public static void Main(string[] args)
		{
			// Input: nums = [1,2,3,4,5]
			// Output: true
			// Explanation: Any triplet where i < j < k is valid.
			bool test1Output = IncreasingTriplet([1, 2, 3, 4, 5]);
			bool test1Expected = true;

			Debug.Assert(test1Expected == test1Output, FormatTestErrorMessage(1, test1Expected, test1Output));

			// Input: nums = [5,4,3,2,1]
			// Output: false
			// Explanation: No triplet exists.
			bool test2Output = IncreasingTriplet([5, 4, 3, 2, 1]);
			bool test2Expected = false;

			Debug.Assert(test2Expected == test2Output, FormatTestErrorMessage(2, test2Expected, test2Output));

			// Input: nums = [2,1,5,0,4,6]
			// Output: true
			// Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
			bool test3Output = IncreasingTriplet([2, 1, 5, 0, 4, 6]);
			bool test3Expected = true;

			Debug.Assert(test3Expected == test3Output, FormatTestErrorMessage(3, test3Expected, test3Output));

			// Input: nums = [20,100,10,12,5,13]
			// Output: true
			// Explanation: the triplet 10, 12, 13 is valid but is missed 
			bool test4Output = IncreasingTriplet([20,100,10,12,5,13]);
			bool test4Expected = true;

			Debug.Assert(test4Expected == test4Output, FormatTestErrorMessage(4, test4Expected, test4Output));
		}
	}
}