using System.Diagnostics;

public class Solution
{
	public void DuplicateZeros(int[] arr)
	{
		for(int i = 0; i < arr.Length; i++)
		{
			if(arr[i] == 0) {
				rightShift(arr, i);
				i++;
			}
		}
	}

	public void rightShift(int[] arr, int pos) {
		for(int i = arr.Length - 1; i > pos; i--) {
			arr[i] = arr[i-1];  
		}
		printArray(arr);
	}

	public void printArray(int[] arr)
	{

		Array.ForEach(arr, Console.Write);
		Console.WriteLine("");
	}

	public static void Main(string[] args)
	{
		Solution ZeroFormatter = new Solution();

		// Input: arr = [1,0,2,3,0,4,5,0]
		// Output: 		[1,0,0,2,3,0,0,4]
		// Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
		int[] test1Output = new int[] { 1, 0, 2, 3, 0, 4, 5, 0 };
		ZeroFormatter.DuplicateZeros(test1Output);
		int[] test1Expected = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 };
		Debug.Assert(test1Output.SequenceEqual(test1Expected), formatTestErrorMessage<int[]>("1", test1Expected, test1Output));

		// Input: arr = [1,2,3]
		// Output: 		[1,2,3]
		// Explanation: After calling your function, the input array is modified to: [1,2,3]
		int[] test2Output = new int[] { 1, 2, 3 };
		ZeroFormatter.DuplicateZeros(test2Output);
		int[] test2Expected = new int[] { 1, 2, 3 };
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
