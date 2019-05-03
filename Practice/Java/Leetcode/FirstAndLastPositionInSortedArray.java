//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
package Leetcode;
import javax.lang.model.util.ElementScanner6;

public class FirstAndLastPositionInSortedArray{
    public static void main(String[] args) {
        FirstAndLastPositionInSortedArray a = new FirstAndLastPositionInSortedArray();
        int[] nums = {1};
        int target = 1;
        int[] result = a.searchRange(nums, target);
    }
    public int[] searchRange(int[] nums, int target) {
        /*
        Algo: 
        1. Use Binary Search to look for target
        2. If not find return a new array of [-1, -1]
        3. If found get the index
        4. Now have 2 loop from the location found to the 0 AND location found to end.
        5. This will give you the start and ex index
        */
        int location = BinarySearch(nums, target);
        if(location == -1)
            return new int[]  {-1,-1};
        else{
            //location to start
            int start = location;
            int end = location;
            for(int i=start-1;i>=0;i--){
                if(nums[location] == nums[i])
                    start = i;
            }
            for(int j=start+1;j<nums.length;j++){
                if(nums[location] == nums[j])
                    end = j;
            }
            return new int[] {start,end};
        }

    }
    public int BinarySearch(int[] nums, int target)
    {
        int start = 0;
        int end = nums.length-1;
        while(end >= start){
            int mid = (start + end) / 2;
            if(target > nums[mid])
                start = mid + 1;
            else if (target < nums[mid])
                end = mid - 1;
            else
                return mid;
        }
        return -1;
    }
}