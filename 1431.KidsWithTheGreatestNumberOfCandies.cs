using System.Diagnostics;
using System.Text;

public class KidsWithTheGreatestNumberOfCandies
{
	public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
	{
		IList<bool> greatestNumberOfCandies = new List<bool>();

		return greatestNumberOfCandies;
	}

	public static void Main(string[] args)
	{
		KidsWithTheGreatestNumberOfCandies candyAllocator = new KidsWithTheGreatestNumberOfCandies();

		// Input: candies = [2,3,5,1,3], extraCandies = 3
		// Output: [true,true,true,false,true] 

		IList<bool> test1Output = candyAllocator.KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);
		IList<bool> test1Expected = new List<bool> { true, true, true, false, true };
		Debug.Assert(test1Output.SequenceEqual(test1Expected), formatTestErrorMessage("1", test1Expected, test1Output));

		// Input: candies = [4,2,1,1,2], extraCandies = 1
		// Output: [true,false,false,false,false] 

		IList<bool> test2Output = candyAllocator.KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);
		IList<bool> test2Expected = new List<bool> { true, false, false, false, false };
		Debug.Assert(test2Output.SequenceEqual(test2Expected), formatTestErrorMessage("2", test2Expected, test2Output));

		// Input: candies = [12,1,12], extraCandies = 10
		// Output: [true,false,true]

		IList<bool> test3Output = candyAllocator.KidsWithCandies(new int[] { 12, 1, 12 }, 10);
		IList<bool> test3Expected = new List<bool> { true, false, true };
		Debug.Assert(test3Output.SequenceEqual(test3Expected), formatTestErrorMessage("3", test3Expected, test3Output));

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

	public static string formatTestErrorMessage(string test, IList<bool> expected, IList<bool> actual)
	{
		string expectedString = string.Join(", ", expected);
		string actualString = string.Join(", ", actual);

		return $"-----\nTest {test} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
	}
}
