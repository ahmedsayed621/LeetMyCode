public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        var MOD = 1000000007;
        //Sort H cuts and V cuts
        Array.Sort(horizontalCuts);
        Array.Sort(verticalCuts);
        
        //Find the Max width for the first and last piece with horizontal cuts
        //Then compare with the rest of the horizontal pieces which will give
        //the max Height of the cake.
        var maxHeight = Math.Max(horizontalCuts[0], h - horizontalCuts[horizontalCuts.Length - 1]);
        for(int i = 1; i < horizontalCuts.Length; i++)
        {
            maxHeight = Math.Max(maxHeight, horizontalCuts[i] - horizontalCuts[i - 1]);
        }
        
        var maxWidth = Math.Max(verticalCuts[0], w - verticalCuts[verticalCuts.Length - 1]);
        for(int i = 1; i < verticalCuts.Length; i++)
        {
            maxWidth = Math.Max(maxWidth, verticalCuts[i] - verticalCuts[i - 1]);
        }
        
        var maxArea = (long)maxHeight*maxWidth;
        
        return (int)(maxArea%MOD);
    }
}