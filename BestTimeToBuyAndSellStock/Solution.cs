namespace BestTimeToBuyAndSellStock;


// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
// Best Time to Buy and Sell Stock

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var min = prices[0];
        var profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
                continue;
            }

            if ((prices[i] - min) > profit)
            {
                profit = prices[i] - min;
            }
        }

        return profit;
    }
}