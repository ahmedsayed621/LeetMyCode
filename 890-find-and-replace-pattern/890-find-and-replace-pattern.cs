public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        string p = Help(pattern);
        return words.Where(x => Help(x) == p).ToList();
    }
    
    private string Help(string str) {
        char[] chars = new char[26];
        char cur = 'a';
        string res = string.Empty;
        foreach(char c in str) {
            int i = c - 'a';
            if(chars[i] == 0) chars[i] = cur++;
            res += chars[i];
        }
        return res;
    }
}