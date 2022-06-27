public class Solution {
    public int MinPartitions(string n) {
        if(n == null || n == "")
            return 0;
        
        int max = 0;
        foreach(char c in n)
        {
            int val = c - '0';
            max = Math.Max(max, val);
        }
        
        return max;
    }
}