public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> hash = new HashSet<int>();
        
        for(int i=0 ; i<nums.Length;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[i]+nums[j]==target){
                    hash.Add(i);
                    hash.Add(j);
                }
                
            }
        }
        return hash.ToArray();
    }
}