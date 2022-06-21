public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        var jumps = new SortedList<int, int>(); // to sort heights
        var n = heights.Length;
        int count = 0;
        
        
        for (int i = 1; i < n; i++)
        {
            if (heights[i-1] < heights[i])
            {
                var h = heights[i]-heights[i-1];
                // Console.WriteLine($"h:{h}");
                
				// check if duplicated height
                if (jumps.ContainsKey(h))
                    jumps[h]++;
                else
                    jumps[h] = 1;
                
                count++;
                
                if (count > ladders)
                {
                    var min =  jumps.First();
                    
                    // Console.WriteLine($"min:{min.Key},{min.Value}");
                    bricks -= min.Key;                    
                    
                    if (bricks < 0) return i-1;
                    
					// remove considering that can be more than one with same height
                    if (min.Value == 1)
                        jumps.Remove(min.Key);
                    else
                        jumps[min.Key]--;
                    
                    count--;
                }                
            }                
        }
        
        return n-1;
    }
}