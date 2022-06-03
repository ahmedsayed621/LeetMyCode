public class NumMatrix
{
    int[][] sum;

    public NumMatrix(int[][] matrix)
    {
        int m = matrix.Length;
        if (m == 0)
            return;
        int n = matrix[0].Length;
        if (n == 0)
            return;
        sum = new int[m + 1][];
        for (int i = 0; i < m + 1; i++)
        {
            sum[i] = new int[n + 1];
        }
        
        for (int r = 1; r <= m; r++)
        {
            for (int c = 1; c <= n; c++)
            {
                sum[r][c] = matrix[r - 1][c - 1] + sum[r - 1][c] + sum[r][c - 1] - sum[r - 1][c - 1];
            }
        }        
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        return sum[row2 + 1][col2 + 1] - sum[row1][col2 + 1] - sum[row2 + 1][col1] +sum[row1][col1];        
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */