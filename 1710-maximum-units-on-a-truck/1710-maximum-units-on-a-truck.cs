public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        if (boxTypes == null || boxTypes.Length == 0)
            return 0;
        
        int res = 0,
            size = 0;
        
        boxTypes = boxTypes.OrderByDescending(x => x[1]).ToArray();
        
        foreach (var item in boxTypes)
        {
            int cur = item[0];
            
            while (cur > 0)
            {
                if (size == truckSize)
                    return res;
                
                res += item[1];
                
                size++;
                cur--;
            }
        }
         
        return res;
    }
}