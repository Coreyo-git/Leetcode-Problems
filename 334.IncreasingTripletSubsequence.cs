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
		}
	}
}