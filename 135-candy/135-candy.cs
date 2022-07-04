public class Solution {
     public int Candy(int[] r) {
        int len = r.Length;
        int[] res = new int[len];
        
        //Each child must have at least one candy
        Array.Fill(res, 1);
        
        //Children with a higher rating get more candies than their neighbors.
        for(int i = 1; i < len; i++)
        {
            if(r[i] > r[i - 1])
                res[i] = res[i - 1] + 1;
        }
        
        for(int i = len-2; i >= 0; i--)
        {
            if(r[i] > r[i + 1])
                res[i] = Math.Max(res[i], res[i + 1] + 1);
        }
        
        return res.Sum();
    }
}