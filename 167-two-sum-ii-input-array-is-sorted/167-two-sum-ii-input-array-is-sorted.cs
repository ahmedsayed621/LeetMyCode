public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
       int arrayLength= numbers.Length;
        
        //validtion
        if(numbers==null || arrayLength<2) return Array.Empty<int>();
        
        for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                        return new int[2] { i+1, j +1};
                }
            }
            return Array.Empty<int>();
       
        
        
    }
}