public class Solution {
    public int MinDeletions(string s) {
       var dict = new Dictionary<char, int>();
        int k = 0, m = 0;
        //check chars and add to dict 
        foreach (var ch in s)
        {
            if (dict.ContainsKey(ch))
                dict[ch]++;
            else
                dict.Add(ch, 1);
        }
        
        
        
        var countArr = new int[dict.Count()];
        foreach (var d in dict.Values)
        {
            countArr[m++] = d;
        }
        
        Array.Sort(countArr);
        var num = countArr[countArr.Length - 1] - 1;
        for (var i = countArr.Length - 2; i >= 0; i--)
        {
            if (countArr[i] > num)
            {
                k += countArr[i] - num;
                if (num != 0)
                    num--;
            }
            else
            {
                num = countArr[i] - 1;
            }
        }
        
        return k;
    }
}