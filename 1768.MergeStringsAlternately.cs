using System.Diagnostics;
using System.Text;

public class MergeStringsAlternately
{
	public string MergeAlternately(string word1, string word2)
	{
		if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2)) return word1 + word2;
		char[] w1Letters = word1.ToCharArray();
		char[] w2Letters = word2.ToCharArray();
		StringBuilder mergedWord = new StringBuilder();

		while (w1Letters.Length > 0 || w2Letters.Length > 0)
		{
			if (w1Letters.Length > 0)
			{
				mergedWord.Append(w1Letters[0]);
				w1Letters = w1Letters[1..];
			}
			if (w2Letters.Length > 0)
			{
				mergedWord.Append(w2Letters[0]);
				w2Letters = w2Letters[1..];
			}
		}
		return mergedWord.ToString();
	}

	public static void Main(string[] args)
	{
		MergeStringsAlternately stringMerger = new MergeStringsAlternately();

		// Input: word1 = "abc", word2 = "pqr"
		// Output: "apbqcr"
		// Explanation: The merged string will be merged as so:
		// word1:  a   b   c
		// word2:    p   q   r
		// merged: a p b q c r

		string test1Output = stringMerger.MergeAlternately("abc", "pqr");
		string test1Expected = "apbqcr";
		Debug.Assert(test1Output == test1Expected, formatTestErrorMessage("1", test1Expected, test1Output));

		// Input: word1 = "ab", word2 = "pqrs"
		// Output: "apbqrs"
		// Explanation: Notice that as word2 is longer, "rs" is appended to the end.
		// word1:  a   b 
		// word2:    p   q   r   s
		// merged: a p b q   r   s

		string test2Output = stringMerger.MergeAlternately("ab", "pqrs");
		string test2Expected = "apbqrs";
		Debug.Assert(test2Output == test2Expected, formatTestErrorMessage("2", test2Expected, test2Output));

		// Input: word1 = "abcd", word2 = "pq"
		// Output: "apbqcd"
		// Explanation: Notice that as word1 is longer, "cd" is appended to the end.
		// word1:  a   b   c   d
		// word2:    p   q 
		// merged: a p b q c   d

		string test3Output = stringMerger.MergeAlternately("abcd", "pq");
		string test3Expected = "apbqcd";
		Debug.Assert(test3Output == test3Expected, formatTestErrorMessage("3", test3Expected, test3Output));

	}

	/// <summary>
	/// Formats the error message for a test case by including the test name, expected result, and actual result.
	/// </summary>
	/// <param name="test">The name or description of the test case.</param>
	/// <param name="expected">The expected result of the test case.</param>
	/// <param name="actual">The actual result obtained during the test case.</param>
	/// <returns>A formatted error message that includes the test case details.</returns>
	public static string formatTestErrorMessage(string test, string expected, string actual)
	{
		return $"-----\nTest {test} Failed\nExpected: {expected}\nActual: {actual}\n-----";
	}
}
