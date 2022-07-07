public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length) return false;
        var dp = new int[s1.Length + 1, s2.Length + 1];
        dp[0, 0] = 1;
        for (var i = 0; i < s1.Length + 1; ++i)
        for (var j = 0; j < s2.Length + 1; ++j)
        {
            if (i - 1 >= 0 && i - 1 < s1.Length && dp[i - 1, j] > 0 && s1[i - 1] == s3[dp[i - 1, j] - 1])
                dp[i, j] = dp[i - 1, j] + 1;
            if (j - 1 >= 0 && j - 1 < s2.Length && dp[i, j - 1] > 0 && s2[j - 1] == s3[dp[i, j - 1] - 1])
                dp[i, j] = Math.Max(dp[i, j - 1] + 1, dp[i, j]);
        }
        return dp[s1.Length, s2.Length] == s3.Length + 1;
    }
}