public class BestTimeToBuyAndSellStock
{

	public int MaxProfit(int[] prices)
	{
		int max_profit = 0;

		return max_profit;
	}
	public static void Main(string[] args)
	{
		BestTimeToBuyAndSellStock stocksCalc = new BestTimeToBuyAndSellStock();
		
		// Input: prices = [7,1,5,3,6,4]
		// Output: 5
		// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
		// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
		int[] prices1 = {7,1,5,3,6,4};
		int test1 = stocksCalc.MaxProfit(prices1);

		// Input: prices = [7,6,4,3,1]
		// Output: 0
		// Explanation: In this case, no transactions are done and the max profit = 0.
		int[] prices2 ={7,6,4,3,1};
		int test2 = stocksCalc.MaxProfit(prices2);
	}
}

