public class Solution {
    public int Search(int[] nums, int target) {
        
        
        int start =0;
        int end =nums.Length-1;
        while(start<=end)
        {
            int mid = start + (end - start)/2;
            if(nums[mid]==target)
                return mid;
            if (nums[mid]<target)
                start=mid+1;
            if (nums[mid]>target)
                end=mid-1;
        }
        return -1;
    }
}