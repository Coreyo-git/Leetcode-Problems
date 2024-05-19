using System.Diagnostics;
using static Leetcode.TestUtils;

namespace Leetcode
{
    public class Solution
    {
        // Given an array of integers arr, 
        // return true if the number of occurrences
        // of each value in the array is unique or false otherwise.
        public static bool UniqueOccurrences(int[] arr)
        {
            return false;
        }

        public static void Main(string[] args)
        {
            // Test 1
            // Input: arr = [1,2,2,1,1,3]
            // Output: true
            // Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1.
            //              No two values have the same number of occurrences.
            bool test1Output = UniqueOccurrences([1, 2, 2, 1, 1, 3]);
            bool test1Expected = true;

            Debug.Assert(test1Expected == test1Output, FormatTestErrorMessage(1, test1Expected, test1Output));

            // Test 2
            // Input: arr = [1,2]
            // Output: false
            bool test2Output = UniqueOccurrences([1, 2]);
            bool test2Expected = false;

            Debug.Assert(test2Expected == test2Output, FormatTestErrorMessage(2, test2Expected, test2Output));

            // Test 3
            // Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
            // Output: true
            bool test3Output = UniqueOccurrences([-3,0,1,-3,1,1,1,-3,10,0]);
            bool test3Expected = true;

            Debug.Assert(test3Expected == test3Output, FormatTestErrorMessage(3, test3Expected, test3Output));
        }
    }
}