using System.Text;
using System.Diagnostics;

// For two strings s and t, we say "t divides s" 
// 	if and only if s = t + ... + t 
//  (i.e., t is concatenated with itself one or more times).

// Given two strings str1 and str2, 
// 	return the largest string x such that 
//  x divides both str1 and str2.
public class GreatestCommonDivisorOfStrings
{

	public string GcdOfStrings(string str1, string str2)
	{
		//checks if the concatenated strings are equal. 
		// If they are not equal, it means they cannot from a GCD
		if (!(str1 + str2).Equals(str2 + str1))
		{
			return "";
		}

		int gcdLength = GetGcdLength(str1.Length, str2.Length);
		return str1.Substring(0, gcdLength);
	}

	// Euclidean algorithm to find the GCD
	private int GetGcdLength(int a, int b)
	{
		Console.WriteLine(a);
		if (b == 0)
		{
			return a;
		}
		
		return GetGcdLength(b, a % b);
	}

	public static void Main(string[] args)
	{
		GreatestCommonDivisorOfStrings stringDivisor = new GreatestCommonDivisorOfStrings();

		// Input: str1 = "ABCABC", str2 = "ABC"
		// Output: "ABC"

		string test1Output = stringDivisor.GcdOfStrings("ABCABC", "ABC");
		string test1Expected = "ABC";
		Debug.Assert(test1Output == test1Expected, formatTestErrorMessage("1", test1Expected, test1Output));

		// Input: str1 = "ABABAB", str2 = "ABAB"
		// Output: "AB"

		string test2Output = stringDivisor.GcdOfStrings("ABABAB", "ABAB");
		string test2Expected = "AB";
		Debug.Assert(test2Output == test2Expected, formatTestErrorMessage("2", test2Expected, test2Output));

		// Input: str1 = "LEET", str2 = "CODE"
		// Output: ""

		string test3Output = stringDivisor.GcdOfStrings("LEET", "CODE");
		string test3Expected = "";
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
