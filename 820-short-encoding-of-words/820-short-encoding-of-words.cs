public class Solution {
    public int MinimumLengthEncoding(string[] words) {
        HashSet<string> set = words.ToHashSet();
        
        foreach(var word in words)
        {
            for(int i=1; i<word.Length; i++)
            {
                string suffix = word.Substring(i, word.Length - i);
                set.Remove(suffix);
            }
        }
        
        return set.Any() ? set.Sum(x => x.Length + 1) : 0;
    }
}