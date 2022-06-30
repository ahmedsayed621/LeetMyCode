public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        var median = nums[nums.Length / 2];
        var result = nums.Sum(num => Math.Abs(median - num));
        return result;
    }
}