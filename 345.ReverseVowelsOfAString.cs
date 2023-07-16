using System.Diagnostics;
using System.Text;

public class ReverseVowelsOfAString
{
	public string ReverseVowels(string s)
	{
		if (s.Length < 1) return s;
		HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
		char[] chars = s.ToCharArray();
		int start = 0;
		int end = s.Length - 1;
		bool startFound = false;
		bool endFound = false;

		while (start < end)
		{			
			if (!startFound && vowels.Contains(char.ToLower(s[start])))
			{
				startFound = true;
			}
			if (!startFound) start++;

			
			
			if (!endFound && vowels.Contains(char.ToLower(s[end])))
			{
				endFound = true;
			}
			if (!endFound) end--;

			if (endFound && startFound) {
				char temp = s[start];
				chars[start] = chars[end];
				chars[end] = temp;
				endFound = false;
				startFound = false;
				start++;
				end--;
			}
		}


		return string.Join("", chars);
	}

	public static void Main(string[] args)
	{
		ReverseVowelsOfAString vowelReverser = new ReverseVowelsOfAString();

		// Input: s = "hello"
		// Output: "holle"

		string test1Output = vowelReverser.ReverseVowels("hello");
		string test1Expected = "holle";
		Debug.Assert(test1Output == test1Expected, formatTestErrorMessage<string>("1", test1Expected, test1Output));

		// Input: s = "leetcode"
		// Output: "leotcede"
		string test2Output = vowelReverser.ReverseVowels("leetcode");
		string test2Expected = "leotcede";
		Debug.Assert(test2Output == test2Expected, formatTestErrorMessage<string>("2", test2Expected, test2Output));

		// Input: s = "aA"
		// Output: "Aa"
		string test3Output = vowelReverser.ReverseVowels("aA");
		string test3Expected = "Aa";
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
