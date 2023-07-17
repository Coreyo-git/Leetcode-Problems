using System.Diagnostics;
using System.Text;

public class ReverseWordsInAString
{
	public string ReverseWords(string s)
	{
		if(string.IsNullOrEmpty(s)) return s;
		string[] reversedWords = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
		int lastWordIndex = reversedWords.Length - 1;
		for(int i = 0; i < lastWordIndex; i++) {
			string temp = reversedWords[i];
			reversedWords[i] = reversedWords[lastWordIndex];
			reversedWords[lastWordIndex] = temp;
			lastWordIndex--;
		}

		return string.Join(" ", reversedWords);
	}


	public static void Main(string[] args)
	{
		ReverseWordsInAString wordReverser = new ReverseWordsInAString();

		// Input: s = "hello"
		// Output: "holle"

		string test1Output = wordReverser.ReverseWords("the sky is blue");
		string test1Expected = "blue is sky the";
		Debug.Assert(test1Output == test1Expected, formatTestErrorMessage<string>("1", test1Expected, test1Output));

		// Input: s = "leetcode"
		// Output: "leotcede"
		string test2Output = wordReverser.ReverseWords("  hello world  ");
		string test2Expected = "world hello";
		Debug.Assert(test2Output == test2Expected, formatTestErrorMessage<string>("2", test2Expected, test2Output));

		// Input: s = "aA"
		// Output: "Aa"
		string test3Output = wordReverser.ReverseWords("a good   example");
		string test3Expected = "example good a";
		Debug.Assert(test3Output == test3Expected, formatTestErrorMessage<string>("3", test3Expected, test3Output));

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
		string expectedString = expected?.ToString() ?? "null";
		string actualString = actual?.ToString() ?? "null";

		return $"-----\nTest {test} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
	}
}
