package Leetcode;
public class MaxConsecutiveOnes{
    public static void main(String[] args) {
        int[] input = {1,1,1,0,0,0,1,1,1,1,0};
        MaxConsecutiveOnes a = new MaxConsecutiveOnes();
        int result = a.longestOnes(input, 2);
    }
    public int longestOnes(int[] A, int K) {
        //if(K == 0) return 0;
        int end = 0;
        int start = 0;
        int maxLength = Integer.MIN_VALUE;
        
        while(end < A.length) {
            if(A[end] == 0) K--;
            while(K < 0 && start <= end) {
                if(A[start] == 0) {
                    K++;
                }
                start++;
            }
            end++;
            maxLength = Math.max(maxLength, end - start);
        }
        return maxLength;
    }
}