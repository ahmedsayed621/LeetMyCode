public class Solution {
    public int KthSmallest(int[][] matrix, int k) 
{
   int n =matrix.Length;
    int result = 0;
    
    // use int[] {value, row, col} to dedupe with custom comparer
    var set = new SortedSet<int[]>(Comparer<int[]>.Create(
        (x, y) => x[0] != y[0] ? 
                 x[0] - y[0] : x[1] != y[1]? x[1] - y[1]:x[2] - y[2]));

        // add the first of each row
        for (int row = 0; row < n; row++)
        {
            set.Add(new int[]{matrix[row][0],row, 0});
        }
    
    
       while (k > 0)
            {
                // pop the min of the rows
                var min = set.Min;
                set.Remove(min);

                result = min[0];
                // row
                int x =  min[1];
                // col
                var y =  min[2];


                if (y < n - 1)
                {   // go to next col of the same row
                    set.Add(new int[]{matrix[x][y + 1],x, y + 1});
                }

                k--; 
            }

            return result;
}
}