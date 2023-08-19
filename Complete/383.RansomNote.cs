using System.Diagnostics;

public class Solution
{
	public bool CanConstruct(string ransomNote, string magazine)
	{
		Dictionary<char, int> charCount = new Dictionary<char, int>();

		foreach (char c in magazine)
		{
			if (charCount.ContainsKey(c))
			{
				charCount[c]++;
			}
			else
			{
				charCount.Add(c, 1);
			}
		}

		foreach (char c in ransomNote)
		{
			if (!charCount.ContainsKey(c) || charCount[c] == 0)
			{
				return false;
			}
			charCount[c]--;
		}

		return true;
	}

	public static void Main(string[] args)
	{
		Solution RansomDecoder = new Solution();

		// Input: ransomNote = "a", magazine = "b"
		// Output: false
		bool test1Output = RansomDecoder.CanConstruct("a", "b");
		bool test1Expected = false;
		Debug.Assert(!test1Output, formatTestErrorMessage<bool>("1", test1Expected, test1Output));

		// Input: ransomNote = "aa", magazine = "ab"
		// Output: false
		bool test2Output = RansomDecoder.CanConstruct("aa", "ab");
		bool test2Expected = false;
		Debug.Assert(!test2Output, formatTestErrorMessage<bool>("2", test2Expected, test2Output));


		// Input: ransomNote = "aa", magazine = "aab"
		// Output: true
		bool test3Output = RansomDecoder.CanConstruct("aa", "aab");
		bool test3Expected = true;
		Debug.Assert(test3Output, formatTestErrorMessage<bool>("3", test3Expected, test3Output));

		// Input: ransomNote = "aab", magazine = "baa"
		// Output: true
		bool test4Output = RansomDecoder.CanConstruct("aab", "baa");
		bool test4Expected = true;
		Debug.Assert(test4Output, formatTestErrorMessage<bool>("4", test4Expected, test4Output));

		// Input: ransomNote = "bg", magazine = "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"
		// Output: true
		bool test5Output = RansomDecoder.CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj");
		bool test5Expected = true;
		Debug.Assert(test5Output, formatTestErrorMessage<bool>("5", test5Expected, test5Output));

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
		else if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(IList<>))
		{
			dynamic expectedList = expected!;
			dynamic actualList = actual!;

			string expectedString = "[" + string.Join(", ", expectedList) + "]";
			string actualString = "[" + string.Join(", ", actualList) + "]";

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
