public class Solution {
    public int MaxProfit(int[] prices) {
        
        int minProfit=int.MaxValue;
        int maxProfit=0;
        
        for(int i = 0 ; i<prices.Length;i++)
        {
            if(prices[i]<minProfit)
                minProfit=prices[i];
            
            else if(prices[i]-minProfit > maxProfit)
                maxProfit = prices[i]-minProfit;
            
        }
        
        return maxProfit;
    }
}