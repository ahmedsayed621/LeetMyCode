public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        if(grid == null)
            return 0;
        
        int numIslands = 0;
        int res = 0;
        
        for(int row=0;row<grid.Length;++row){
            for(int col=0;col<grid[row].Length;++col){
                if(grid[row][col] == 1)
                    numIslands = DFS(grid, row, col);
                if(numIslands > res)
                    res = numIslands;
            }
        }
        
        return res;
    }
    
    private int DFS(int[][] grid, int row, int col){
        if(row < 0 || row > grid.Length - 1 || col < 0 || col > grid[row].Length - 1 || grid[row][col] == 0)
            return 0;
        
        grid[row][col] = 0;
        
        int val = DFS(grid, row+1, col) + 
        DFS(grid, row-1, col) +
        DFS(grid, row, col+1) +
        DFS(grid, row, col-1);
        
        return val + 1;
    }
}