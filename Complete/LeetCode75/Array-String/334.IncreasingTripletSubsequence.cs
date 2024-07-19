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
			int n = nums.Length;

			// impossible for a triplet with less than 3 len
			if (n < 3) return false;
			
			// create a new array with the lowest possible
			// start of the triplet from index 0 to n 
			int[] leftMin = new int[n];
			
			// init leftMin[0] with the nums[0] setting it equal
			// as the lowest possible found for future comparisons
			leftMin[0] = nums[0];
			for (int i = 1; i < n; i++)
			{
				// if the current index value is lower
				// than the previous lowest leftMin value
				// update the lowest left value at this index 
				// with the new lowest value found.
				if (nums[i] < leftMin[i - 1])
					leftMin[i] = nums[i];
				
				// else the previous lowest leftMin value is 
				// greater than the current index value
				// update the lowest left at this index 
				// equal to the existing lowest and continue.
				else 
					leftMin[i] = leftMin[i - 1];
			}

			// create a new array with the highest possible
			// end of a triplet from right to left
			// (this is the inverse of the leftMin array above) 
			int[] rightMax = new int[n];

			// init rightMax[n-1] with the nums[n-1] setting it equal
			// as the highest possible found for future comparisons
			rightMax[n-1] = nums[n-1];
			for(int i = n - 2; i >= 0; i--)
			{
				if(nums[i] > rightMax[i+1])
					rightMax[i] = nums[i];
				else rightMax[i] = rightMax[i+1];
			}

			// loop through nums using leftMin and rightMax as a reference.
			// if leftMin[i] is lower than the current nums[i]
			// we know that there is atleast a twin subsequence to left of the current index
			// if rightMax[i] is higher than the current nums[i] 
			// we know that there is atleast a twin index to the right in the array.
			// if both the prior and latter are true, then we know a triplet subsequence is present in the array.
			for(int i = 0; i < n; i++)
			{
				if(nums[i] > leftMin[i] && nums[i] < rightMax[i]) 
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
			// Explanation: The triplet (2, 3, 5) is valid because nums[2] == 10 < nums[3] == 12 < nums[5] == 13.
			bool test4Output = IncreasingTriplet([20, 100, 10, 12, 5, 13]);
			bool test4Expected = true;

			Debug.Assert(test4Expected == test4Output, FormatTestErrorMessage(4, test4Expected, test4Output));
		}
	}
}