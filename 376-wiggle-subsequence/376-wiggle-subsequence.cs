public class Solution {
    public int WiggleMaxLength(int[] nums) {
        //Question basically wants us to find the no. of peaks and valleys
        int peak = 1, valley = 1;
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > nums[i - 1])
                peak = valley + 1;
            else if(nums[i] < nums[i - 1])
                valley = peak + 1;
        }
        
        return Math.Max(peak, valley);
    }
}