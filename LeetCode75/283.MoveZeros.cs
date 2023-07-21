using System.Diagnostics;

public class Zeros

{
	public void MoveZeroes(int[] nums)
	{
		int i = 0;
		int j = 0;
		while (j < nums.Length)
		{
			if (nums[j] != 0)
			{
				int temp = nums[j];
				nums[j] = nums[i];
				nums[i] = temp;
				i++;
			}
			j++;
		}
	}

	public static void Main(string[] args)
	{
		Zeros zeros = new Zeros();


		// Input: nums = [0, 1, 0, 3, 12 ]
		// Output: [1, 3, 12, 0, 0]

		int[] test1Output = { 0, 1, 0, 3, 12 };
		zeros.MoveZeroes(test1Output);
		int[] test1Expected = { 1, 3, 12, 0, 0 };
		Debug.Assert(test1Output.SequenceEqual(test1Expected), formatTestErrorMessage<int[]>("1", test1Expected, test1Output));

		// Input: nums = [0]
		// Output: [0]

		int[] test2Output = { 0 };
		zeros.MoveZeroes(test2Output);
		int[] test2Expected = { 0 };
		Debug.Assert(test2Output.SequenceEqual(test2Expected), formatTestErrorMessage<int[]>("2", test2Expected, test2Output));

		// Input: nums = [4,2,4,0,0,3,0,5,1,0]
		// Output: [4,2,4,3,5,1,0,0,0,0]
		int[] test3Output = { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 };
		zeros.MoveZeroes(test3Output);
		int[] test3Expected = { 4, 2, 4, 3, 5, 1, 0, 0, 0, 0 };
		Debug.Assert(test3Output.SequenceEqual(test3Expected), formatTestErrorMessage<int[]>("3", test3Expected, test3Output));
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
