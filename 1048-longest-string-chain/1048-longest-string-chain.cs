public class Solution {
        public int LongestStrChain(string[] words) 
    {
        var chainLength = new Dictionary<string, int>();
        var lengthMap = new SortedList<int, HashSet<string>>();
        foreach(var word in words)
        {
            if(!lengthMap.ContainsKey(word.Length))
                lengthMap[word.Length] = new HashSet<string>();
            lengthMap[word.Length].Add(word);
            chainLength[word] = 1;
        }
        
        foreach(var length in lengthMap.Keys.Reverse())
            if(lengthMap.ContainsKey(length - 1))
                foreach(var word in lengthMap[length])
                    for(int i = 0; i < length; i++)
                    {
                        var word2 = word.Remove(i, 1);
                        if(chainLength.ContainsKey(word2) && chainLength[word] + 1 > chainLength[word2])
                                chainLength[word2] = chainLength[word] + 1;                              
                    }        
        return chainLength.Values.Max();
    }
}