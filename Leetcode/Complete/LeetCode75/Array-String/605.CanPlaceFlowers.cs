using System.Diagnostics;
using System.Text;

public class CanPlaceFlower
{
	public bool CanPlaceFlowers(int[] flowerbed, int n)
	{
		int[] fbed = new int[flowerbed.Length + 2];
		Array.Copy(flowerbed, 0, fbed, 1, flowerbed.Length);

		int placable = 0;
		for (int i = 1; i < fbed.Length - 1; i++)
		{
			if (fbed[i] == 0)
			{
				if (fbed[i - 1] == 0 && fbed[i + 1] == 0)
				{
					i++;
					placable++;
					continue;
				}
			}
		}
		// Console.WriteLine($"\n{placable}");
		// Console.WriteLine("fbed: " + string.Join(", ", fbed));
		return placable >= n;
	}

	public static void Main(string[] args)
	{
		CanPlaceFlower plotChecker = new CanPlaceFlower();

		// Input: flowerbed = [1,0,0,0,1], n = 1
		// Output: true
		bool test1Output = plotChecker.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1);
		bool test1Expected = true;
		Debug.Assert(test1Output, formatTestErrorMessage<bool>("1", test1Expected, test1Output));

		// Input: flowerbed = [1,0,0,0,1], n = 2
		// Output: false
		bool test2Output = plotChecker.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2);
		bool test2Expected = false;
		Debug.Assert(!test2Output, formatTestErrorMessage<bool>("2", test2Expected, test2Output));


		// Input: flowerbed = [1,0,0,0,0,0,1], n = 2
		// Output: true
		bool test3Output = plotChecker.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 2);
		bool test3Expected = true;
		Debug.Assert(test3Output, formatTestErrorMessage<bool>("3", test3Expected, test3Output));

		// Input: flowerbed = [0, 0, 1, 0, 1], n = 2
		// Output: true
		bool test4Output = plotChecker.CanPlaceFlowers(new int[] { 0, 0, 1, 0, 1 }, 1);
		bool test4Expected = true;
		Debug.Assert(test4Output, formatTestErrorMessage<bool>("4", test4Expected, test4Output));

		// Input: flowerbed = [1, 0, 0, 0, 1, 0, 0], n = 2
		// Output: true
		bool test5Output = plotChecker.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1, 0, 0 }, 2);
		bool test5Expected = true;
		Debug.Assert(test5Output, formatTestErrorMessage<bool>("5", test5Expected, test5Output));

		// Input: flowerbed = [0], n = 1
		// Output: true
		bool test6Output = plotChecker.CanPlaceFlowers(new int[] { 0 }, 1);
		bool test6Expected = true;
		Debug.Assert(test6Output, formatTestErrorMessage<bool>("6", test6Expected, test6Output));

		// Input: flowerbed = [1,0], n = 1
		// Output: false
		bool test7Output = plotChecker.CanPlaceFlowers(new int[] { 1, 0 }, 1);
		bool test7Expected = false;
		Debug.Assert(!test7Output, formatTestErrorMessage<bool>("7", test7Expected, test7Output));

		// Input: flowerbed = [0,1,0], n = 1
		// Output: false
		bool test8Output = plotChecker.CanPlaceFlowers(new int[] { 0, 1, 0 }, 1);
		bool test8Expected = false;
		Debug.Assert(!test8Output, formatTestErrorMessage<bool>("8", test8Expected, test8Output));

		// Input: flowerbed = [0,0,1,0,0], n = 1
		// Output: false
		bool test9Output = plotChecker.CanPlaceFlowers(new int[] { 0, 0, 1, 0, 0 }, 1);
		bool test9Expected = true;
		Debug.Assert(test9Output, formatTestErrorMessage<bool>("8", test9Expected, test9Output));
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
