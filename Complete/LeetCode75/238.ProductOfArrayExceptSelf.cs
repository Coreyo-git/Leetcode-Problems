using System.Diagnostics;
using System.Text;

// Had to go to neetcode for this one.
// https://www.youtube.com/watch?v=bNvIQI2wAjk

public class ProductofArrayExceptSelf

{
	public int[] ProductExceptSelf(int[] nums)
	{
		int n = nums.Length;
		int[] res = new int[n];
		int prefix = 1;

		for (int i = 0; i < n; i++)
		{
			res[i] = prefix;
			prefix *= nums[i];
		}

		int postfix = 1;
		for (int i = n - 1; i >= 0; i--)
		{
			res[i] *= postfix;
			postfix *= nums[i];
		}

		return res;
	}


	public static void Main(string[] args)
	{
		ProductofArrayExceptSelf
 		productCalc = new ProductofArrayExceptSelf();

		// 4 | 1 * 2 * 3 = 6
		// 3 | 1 * 2 * 4 = 8
		// 2 | 1 * 3 * 4 = 12 
		// 1 | 2 * 3 * 4 = 24

		// Input: nums = [1,2,3,4]
		// Output:		[24,12,8,6]

		int[] test1Output = productCalc.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
		int[] test1Expected = { 24, 12, 8, 6 };
		Debug.Assert(test1Output.SequenceEqual(test1Expected), formatTestErrorMessage<int[]>("1", test1Expected, test1Output));

		// Input: nums = [-1,1,0,-3,3]
		// Output: [0,0,9,0,0]
		int[] test2Output = productCalc.ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });
		int[] test2Expected = { 0, 0, 9, 0, 0 };
		Debug.Assert(test2Output.SequenceEqual(test2Expected), formatTestErrorMessage<int[]>("2", test2Expected, test2Output));
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
