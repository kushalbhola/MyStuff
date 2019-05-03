//https://leetcode.com/problems/minimum-path-sum/
package Leetcode;
public class MinimumPathSum{
    public static void main(String[] args) {
        MinimumPathSum a = new MinimumPathSum();
        //int[][] grid = {{1,3,1}, {1,5,1}, {4,2,1}};
        int[][] grid = {{1}};
        //int result = a.minPathSum(grid);
        int i = grid[0].length;
        int j = grid[1].length;
        
        String test = "kushal";


    }
    public int minPathSum(int[][] grid) {
        if(grid[0].length == 0)
        {
            
        }
        else if(grid[1].length == 0)
        {

        }
        int[][] DP = new int[grid[0].length][grid[1].length];
        DP[0][0] = grid[0][0];

        for(int i=1;i<DP[0].length;i++){
            DP[i][0] = DP[i-1][0] + grid[i][0];
        }
        for(int j=1;j<DP[1].length;j++){
            DP[0][j] = DP[0][j-1] + grid[0][j];
        }
        
        for(int i=1;i<grid[0].length;i++){
            for(int j=1;j<grid[1].length;j++){
                DP[i][j] = grid[i][j] + Math.min(DP[i-1][j], DP[i][j-1]);
            }
        }
        return DP[DP[0].length - 1][DP[1].length - 1];
    }
    
}