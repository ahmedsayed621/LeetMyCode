public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        
        int sum = 0;
        int res = 0;
        int n = cardPoints.Length;
        //take first k cards from left
        for(int i=0;i<cardPoints.Length && i<k;i++){
            sum+=cardPoints[i];
        }
        res = sum;
// move the window in left, means include cards at the end and exclude cards from right side of the window
        for(int i = cardPoints.Length-1;i>=0 && i>n-1-k;i--){
            sum = sum-cardPoints[k-n + i ] + cardPoints[i];
            res = Math.Max(res, sum);
        }
        
        return res;

    }
}