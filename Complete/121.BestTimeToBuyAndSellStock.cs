using System.Diagnostics;
public class BestTimeToBuyAndSellStock
{

	// let sum = D[0] + D[1] + D[2];
	// let max = sum;
	// 
	// for (let i = 3; i < D.length; i++) {
	//   sum += D[i] - D[i - 3];
	//   if (max < sum) max = sum;
	// }

	public int MaxProfit(int[] prices)
	{
		if(prices.Length < 2) return 0;

		if(prices.Length == 2) return Math.Max(prices[1] - prices[0], 0);

		int lowest = prices[0];
		int max = 0;
		int sum = prices[1] - lowest;

		for (int i = 1; i < prices.Length; i++)
		{
			if (prices[i - 1] < lowest)
			{
				lowest = prices[i - 1];	
			}
			sum = prices[i] - lowest;
			
			if (max < sum) max = sum;
		}
		return max;
	}
	public static void Main(string[] args)
	{
		BestTimeToBuyAndSellStock stocksCalc = new BestTimeToBuyAndSellStock();

		// Input: prices = [7,1,5,3,6,4]
		// Output: 5
		// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
		// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
		int[] prices1 = { 7, 1, 5, 3, 6, 4 };
		int test1 = stocksCalc.MaxProfit(prices1);

		Debug.Assert(test1 == 5, $"Test 1 Failed\nExpected: 5\nActual: {test1}");

		// Input: prices = [7,6,4,3,1]
		// Output: 0
		// Explanation: In this case, no transactions are done and the max profit = 0.
		int[] prices2 = { 7, 6, 4, 3, 1 };
		int test2 = stocksCalc.MaxProfit(prices2);

		Debug.Assert(test2 == 0, $"Test 2 Failed\nExpected: 0\nActual: {test2}");

		// output 1
		int[] prices3 = {1,2};
		int test3 = stocksCalc.MaxProfit(prices3);
		
		Debug.Assert(test3 == 1, $"Test 3 Failed\nExpected: 1\nActual: {test3}");

		// output 0
		int[] prices4 = {1};
		int test4 = stocksCalc.MaxProfit(prices4);
		
		Debug.Assert(test4 == 0, $"Test 4 Failed\nExpected: 0\nActual: {test4}");

		// output 3
		int[] prices5 = {1,4,2};
		int test5 = stocksCalc.MaxProfit(prices5);
		
		Debug.Assert(test5 == 3, $"Test 5 Failed\nExpected: 0\nActual: {test5}");
	}
}

