public class Solution {
    public bool CheckPossibility(int[] nums) {
int counter = 0;
        for (int i = 0; i < nums.Length - 1; ++i) 
        {
            if (nums[i] > nums[i + 1]) 
            {
                if (i < nums.Length - 2 && nums[i] < nums[i + 2]) 
                {
                    ++counter;
                    nums[i + 1] = nums[i];
                }
                else
                {
                    ++counter;
                    if (i == 0) {
                        nums[i] = nums[i + 1];
                        if (i != 0 && nums[i] < nums[i - 1]) 
                        {
                            return false;
                        }
                    }
                    else {
                        nums[i] = nums[i - 1];
                    }
                }
            }
            else if (i != 0 && nums[i] < nums[i - 1]) 
            {
                return false;
            }
        }
        return counter <= 1;
    }
}