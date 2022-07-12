public class Solution {
    public bool Makesquare(int[] matchsticks) {
        if(matchsticks.Length < 4)
            return false;
        
        int perimeter = matchsticks.Sum();
        if(perimeter % 4 != 0)
            return false;
        int side = perimeter / 4;
        matchsticks = matchsticks.OrderByDescending(x => x).ToArray();
        
        return BackTrack(matchsticks, new int[4], 0, side);        
    }
    
    private bool BackTrack(int[] nums, int[] sums, int index, int target)
    {
        if(index == nums.Length)
            return true;
        
        for(int i=0; i<4; i++)
        {
            if(sums[i] + nums[index] > target)
                continue;
            sums[i] += nums[index];
            if(BackTrack(nums, sums, index + 1, target))
                return true;
            sums[i] -= nums[index];
        }
        
        return false;
    }
}