public class Solution {
    private bool IsSubsequence(string s, ref string t)
        {
            if (s.Length > t.Length)
            {
                return false;
            }

            if (s.Length == 0)
            {
                return true;
            }

            int i = 0;
            int j = 0;

            while (true)
            {
                if (i == s.Length)
                {
                    return true;
                }

                if (j == t.Length)
                {
                    return false;
                }

                if (s[i] == t[j])
                {
                    i++;
                    j++;
                    continue;
                }

                j++;
            }
        }

        public int NumMatchingSubseq(string s, string[] words)
        {
            int res = 0;
            IDictionary<string, int> word2Count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!word2Count.ContainsKey(word))
                {
                    word2Count[word] = 0;
                }

                word2Count[word]++;
            }

            foreach (var w2c in word2Count)
            {
                if (IsSubsequence(w2c.Key, ref s))
                {
                    res += w2c.Value;
                }
            }
            return res;
        }
}