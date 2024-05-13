namespace LeetCode;

public class LC_121
{
    public int SellStocks(int[] prices){
        int left = 1, right = prices.Length - 1;   
        int buy = prices[0];
        int profit = 0;

        for(;left<prices.Length;left++){
            if(prices[left]<buy) { buy = prices[left]; }
            
        }

        return 0;
    }
}
