using System.Diagnostics;
using static Leetcode.TestUtils;

namespace Leetcode
{
    public class Solution
    {
        // Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:
        // answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
        // answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
        // Note that the integers in the lists may be returned in any order.
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
			// Create result list and distinct number lists
            IList<IList<int>> result = new List<IList<int>>();
			IList<int> distNums1 = new List<int>();
			IList<int> distNums2 = new List<int>();

			// loop through each list and check if they exist in nums2 or already exist as a duplicate in nums1
			// if both are false add it to the distinct number list
			for (int i = 0; i < nums1.Length; i++)
			{
				if(nums2.Contains(nums1[i]) || distNums1.Contains(nums1[i]))
				{
					continue;
				}
				distNums1.Add(nums1[i]);
			}
			for (int i = 0; i < nums2.Length; i++)
			{
				if(nums1.Contains(nums2[i]) || distNums2.Contains(nums2[i]))
				{
					continue;
				}
				distNums2.Add(nums2[i]);
			}

			// Add final lists to result and return. 
			result.Add(distNums1);
			result.Add(distNums2);

            return result;
        }

        public static void Main(string[] args)
        {
            // Input: nums1 = [1,2,3], nums2 = [2,4,6]
            // Output: [[1,3],[4,6]]
            // Explanation:
            // For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].
            // For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].

            IList<IList<int>> test1Output = FindDifference(new int[] {1,2,3}, new int[] {2,4,6});
            IList<IList<int>> test1Expected = new List<IList<int>>();

            // Add the sublists to test1Expected
            test1Expected.Add(new List<int> { 1, 3 });
            test1Expected.Add(new List<int> { 4, 6 });

            Debug.Assert(AreEqual(test1Expected, test1Output), FormatTestErrorMessage(1, test1Expected, test1Output));

            // Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
            // Output: [[3],[]]
            // Explanation:
            // For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
            // Every integer in nums2 is present in nums1. Therefore, answer[1] = [].

            IList<IList<int>> test2Output = FindDifference(new int[] {1,2,3,3}, new int[] {1,1,2,2});
            IList<IList<int>> test2Expected = new List<IList<int>>();

            // Add the sublists to test1Expected
            test2Expected.Add(new List<int> { 3 });
            test2Expected.Add(new List<int>());

            Debug.Assert(AreEqual(test2Expected, test2Output), FormatTestErrorMessage(2, test2Expected, test2Output));

        }

		// Checks if the inner Lists are equal to one another.
		public static bool AreEqual(IList<IList<int>> list1, IList<IList<int>> list2)
		{
			// if list lengths are not not equal return false
			if (list1.Count != list2.Count)
			{
				return false;
			}

			// loop through list in lists checking for non equality
			for (int i = 0; i < list1.Count; i++)
			{
				if (!list1[i].SequenceEqual(list2[i]))
				{
					return false;
				}
			}

			return true;
		}
    }
}
