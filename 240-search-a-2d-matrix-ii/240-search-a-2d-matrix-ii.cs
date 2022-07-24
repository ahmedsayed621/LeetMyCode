public class Solution {
     public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix == null || matrix.Length == 0 || matrix.First().Length == 0)
            return false;
        
        int m = matrix.Length, n = matrix.First().Length;
        int i = 0, j = n-1;
        
        while(i < m && j >= 0)
        {
            int num = matrix[i][j];
            
            if(num == target)
                return true;
            else if(num > target)
                j--;
            else
                i++;
        }
        
        return false;
    }
}