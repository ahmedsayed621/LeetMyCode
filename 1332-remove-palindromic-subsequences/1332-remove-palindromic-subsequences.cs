public class Solution {
    public int RemovePalindromeSub(string s) {
        return IsPalindrome(s)? 1:2;
    }
    
    private bool IsPalindrome(string s){
        int left = 0;
        int right = s.Length-1;
        
        while(left<right)
        {
            if(s[left++]!= s[right--])
            {
                return false;
            }
        }
        return true;
    }
}