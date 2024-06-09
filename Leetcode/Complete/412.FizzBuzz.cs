using System.Diagnostics;

public class Solution

{
	public IList<string> FizzBuzz(int n)
	{
		IList<string> answer = new List<string>();

		for (int i = 1; i <= n; i++)  // Start from 1 and include n
		{
			if (i % 3 == 0 && i % 5 == 0)
				answer.Add("FizzBuzz");

			else if (i % 3 == 0)
				answer.Add("Fizz");

			else if (i % 5 == 0)
				answer.Add("Buzz");

			else
				answer.Add(i.ToString());

		}

		return answer;
	}

	public static void Main(string[] args)
	{
		Solution FizzBuzzer = new Solution();


		// Input: n = 3
		// Output: ["1","2","Fizz"]

		IList<string> test1Output = FizzBuzzer.FizzBuzz(3);
		IList<string> test1Expected = new List<string> { "1", "2", "Fizz" };
		Debug.Assert(test1Output.SequenceEqual(test1Expected), formatTestErrorMessage<IList<string>>("1", test1Expected, test1Output));

		// Input: n = 5
		// Output: ["1","2","Fizz","4","Buzz"]

		IList<string> test2Output = FizzBuzzer.FizzBuzz(5);
		IList<string> test2Expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
		Debug.Assert(test2Output.SequenceEqual(test2Expected), formatTestErrorMessage<IList<string>>("2", test2Expected, test2Output));

		// Input: n = 15
		// Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]

		IList<string> test3Output = FizzBuzzer.FizzBuzz(15);
		IList<string> test3Expected = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
		Debug.Assert(test3Output.SequenceEqual(test3Expected), formatTestErrorMessage<IList<string>>("2", test3Expected, test3Output));

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
