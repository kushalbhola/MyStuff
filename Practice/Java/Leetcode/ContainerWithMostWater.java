//https://leetcode.com/problems/container-with-most-water/
package Leetcode;
public class ContainerWithMostWater{
        public static void main(String[] args) {
            ContainerWithMostWater a = new ContainerWithMostWater();
            int[] height = {1,8,6,2,5,4,8,3,7};
            int result = a.MaxArea(height);
        }
        public int MaxArea(int[] height) {
            int start = 0;
            int end = height.length - 1;
            int global = -1;
            while(end > start){
                int curr = Math.min(height[start], height[end]) * (end-start);
                if(global < curr){
                    global = curr;
                }
                if(height[start] < height[end])
                    start++;
                else
                    end --;
            }
            return global;
        } 
}