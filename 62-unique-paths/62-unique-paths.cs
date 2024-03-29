public class Solution {
    public int UniquePaths(int m, int n) {
            int[,] matrix = new int[m, n];
            
            matrix[0, 0] = 1;

            if (m > 1)
                for (int i = 1; i <= matrix.GetLength(0) - 1; i++)
                    matrix[i, 0] = 1;

            if (n > 1)
                for (int i = 1; i <= matrix.GetLength(1) - 1; i++)
                    matrix[0, i] = 1;

            for (int i = 1; i <= matrix.GetLength(0) - 1; i++)
                for (int j = 1; j <= matrix.GetLength(1) - 1; j++)
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];

            return matrix[m - 1, n - 1];
    }
}