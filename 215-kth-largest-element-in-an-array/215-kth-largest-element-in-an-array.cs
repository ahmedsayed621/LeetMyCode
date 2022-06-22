public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        SortedList<int,int> map=new SortedList<int,int>();
        int mapSum=0;
        foreach(int num in nums)
        {
            if(map.ContainsKey(-num))
                map[-num]++;
            else
                map.Add(-num,1);
            if(++mapSum>k)
            {
                if(map[map.Keys.Last()]==1)
                    map.Remove(map.Keys.Last());
                else
                    map[map.Keys.Last()]--;
                mapSum--;
            }
        }
        return map.Keys.Last()*-1;
    }
}