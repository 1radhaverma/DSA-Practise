using System;
using System.Collections.Generic;

class Solution
{
	// Function to calculate max profit using brute force
	public int StockBuySell(List<int> prices)
	{
		int maxProfit = 0;

		for (int i = 0; i < prices.Count; i++)
		{
			for (int j = i + 1; j < prices.Count; j++)
			{				
				int profit = prices[j] - prices[i];
			
				maxProfit = Math.Max(maxProfit, profit);
			}
		}

		return maxProfit;
	}
}

// Driver code
class Program
{
	static void Main()
	{
		Solution sol = new Solution();
		List<int> prices = new List<int> { 7, 1, 5, 3, 6, 4 };

		Console.WriteLine("Max Profit: " + sol.StockBuySell(prices));
	}
}
//tc - O(n²).
//---------------------------------------------------------------------
//optimal approach
using System;
using System.Collections.Generic;

class Solution
{
	// Function to calculate maximum profit using single pass
	public int StockBuySell(List<int> prices)
	{
		// Initialize minimum price to a large value
		int minPrice = int.MaxValue;

		int maxProfit = 0;

		foreach (int price in prices)
		{
			if (price < minPrice)
			{
				minPrice = price;
			}
			else
			{
				maxProfit = Math.Max(maxProfit, price - minPrice);
			}
		}

		return maxProfit;
	}
}

// Driver code
class Program
{
	static void Main()
	{
		Solution obj = new Solution();
		List<int> prices = new List<int> { 7, 1, 5, 3, 6, 4 };

		Console.WriteLine(obj.StockBuySell(prices));
	}
}
//Time Complexity: O(n) 
//Space Complexity: O(1) 