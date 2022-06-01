public class Solution {
    public int[] PlusOne(int[] digits) {
     int currValue = 0;
    int carryOver = 1;
    for(int i = digits.Length - 1; i >= 0 ; i--){
        currValue = digits[i] + carryOver;
        digits[i] = currValue%10; // return from 1-9
        carryOver = currValue/10; // if currValue = 10 returns 1
    }
    IList<int> nums = new List<int>(digits);
    
    if(carryOver != 0){
      nums.Insert(0,carryOver);
    }
    
    return nums.ToArray();
}
}