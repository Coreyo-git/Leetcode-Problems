using System.Diagnostics;

public class Solution

{
	public bool IsSubesquence(string s, string t)
	{
		return false;
	}

	public static void Main(string[] args)
	{
		Solution SubsequenceChecker = new Solution();
		// Input: s = "abc", t = "ahbgdc"
		// Output: true

		bool test1Output = SubsequenceChecker.IsSubesquence("abc", "ahbgdc");
		bool test1Expected = true;
		Debug.Assert(test1Output, formatTestErrorMessage<bool>("1", test1Expected, test1Output));

		// Input: s = "axc", t = "ahbgdc"
		// Output: false

		bool test2Output = SubsequenceChecker.IsSubesquence("axc", "ahbgdc");
		bool test2Expected = false;
		Debug.Assert(!test2Output, formatTestErrorMessage<bool>("2", test2Expected, test2Output));
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
