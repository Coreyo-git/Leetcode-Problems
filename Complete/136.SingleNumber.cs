using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

public class Solution
{
	// XOR operator used to perform bit manipulation 
	// XOR will cancel out pairs because they will occupy the same bits 
	// eg... for example 1:
	// 2 ^ 0 = 2 | 0000 ^ 0010 = 0010
	// 2 ^ 2 = 0 | 0010 ^ 0010 = 0000
	// 0 ^ 1 = 1 | 0001 ^ 0000 = 0001 leaving us with 1 to return
	public static int SingleNumber(int[] nums)
	{
		if (nums.Length == 1) return nums[0];

		int result = 0;

		Console.WriteLine();
		// loop thorugh all numbers using XOR operation
		for (int i = 0; i < nums.Length; i++)
		{
			Console.WriteLine(result + " ^ " + nums[i] + " = " + (result ^ nums[i]));
			result = result ^ nums[i];

		}
		Console.WriteLine();

		return result;
	}

	public static void Main(string[] args)
	{
		// Example 1:
		// Input: nums = [2,2,1]
		// Output: 1
		int[] nums1 = new int[] { 2, 2, 1 };
		int test1Output = SingleNumber(nums1);
		int test1Expected = 1;
		Debug.Assert(test1Output.Equals(test1Expected), formatTestErrorMessage<int>("1", test1Expected, test1Output));

		// Example 2:
		// Input: nums = [4, 1, 2, 1, 2]
		// Output: 4
		int[] nums2 = new int[] { 4, 1, 2, 1, 2 };
		int test2Output = SingleNumber(nums2);
		int test2Expected = 4;
		Debug.Assert(test2Output.Equals(test2Expected), formatTestErrorMessage<int>("2", test2Expected, test2Output));

		// Example 3:
		// Input: nums = [1]
		// Output: 1
		int[] nums3 = new int[] { 1 };
		int test3Output = SingleNumber(nums1);
		int test3Expected = 1;
		Debug.Assert(test3Output.Equals(test3Expected), formatTestErrorMessage<int>("3", test3Expected, test3Output));
	}

	/// <summary>
	/// Formats the error message for a test case by including the test name, expected result, and actual result.
	/// </summary>
	/// <param name="test">The name or description of the test case.</param>
	/// <param name="expected">The expected result of the test case.</param>
	/// <param name="actual">The actual result obtained during the test case.</param>
	/// <returns>A formatted error message that includes the test case details.</returns>
	public static string formatTestErrorMessage<T>(string test, T expected, T actual)
	{
		if (typeof(T).IsArray && typeof(T).GetElementType() == typeof(int))
		{
			int[] expectedArray = (int[])(object)expected!;
			int[] actualArray = (int[])(object)actual!;

			string expectedString = "[" + string.Join(", ", expectedArray!) + "]";
			string actualString = "[" + string.Join(", ", actualArray!) + "]";

			return $"-----\nTest {test} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
		}

		else
		{
			string expectedString = expected?.ToString() ?? "null";
			string actualString = actual?.ToString() ?? "null";

			return $"-----\nTest {test} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
		}
	}
}