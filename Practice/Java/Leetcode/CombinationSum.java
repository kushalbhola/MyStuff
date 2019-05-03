/*https://leetcode.com/problems/combination-sum/
https://leetcode.com/problems/combination-sum-ii/
https://leetcode.com/problems/combination-sum-iii/
*/
package Leetcode;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;


public class CombinationSum{
    public static void main(String[] args) {
        CombinationSum a = new CombinationSum();
        int[] candidates = {10,1,2,7,6,1,5};
        int target = 8;
        List<List<Integer>> result = a.combinationSum(candidates, target);
        result = a.combinationSum2(candidates, target);
        result = a.combinationSum3(3, 7);
        int[] nums = {1, 2, 3};
        result = a.subsets(nums);
    }
    public List<List<Integer>> combinationSum(int[] candidates, int target) {
        Arrays.sort(candidates);
        List<List<Integer>> list = new ArrayList<>();
        combinationSumHelper(list, new ArrayList<>(), candidates, target, 0);
        return list;
    }
    private void combinationSumHelper(List<List<Integer>> list , List<Integer> tempList, int[] candidates, int remain, int start){
        if(remain < 0)
            return;
        else if(remain == 0)
            list.add(new ArrayList<>(tempList));
        else
        {
            for(int i = start;i<candidates.length;i++){
                tempList.add(candidates[i]);
                combinationSumHelper(list, tempList, candidates, remain - candidates[i], i);
                tempList.remove(tempList.size() - 1);
            }
        }
    }
    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
        Arrays.sort(candidates);
        List<List<Integer>> list = new ArrayList<>();
        combinationSumHelper2(list, new ArrayList<>(), candidates, target, 0);
        return list;
    }
    private void combinationSumHelper2(List<List<Integer>> list , List<Integer> tempList, int[] candidates, int remain, int start){
        if(remain < 0)
            return;
        else if(remain == 0 && !list.contains(tempList))
            list.add(new ArrayList<>(tempList));
        else
        {
            for(int i = start;i<candidates.length;i++){
                tempList.add(candidates[i]);
                combinationSumHelper2(list, tempList, candidates, remain - candidates[i], i + 1);
                tempList.remove(tempList.size() - 1);
            }
        }
    }
    /*
    k=3
    n=7
    */
    public List<List<Integer>> combinationSum3(int k, int n) {
        List<List<Integer>> list = new ArrayList<>();
        combinationSumHelper3(list, new ArrayList<Integer>(), k, n, 1);
        return list;
    }
    private void combinationSumHelper3(List<List<Integer>> list, List<Integer> tempList, int k, int remain, int start){

        if(remain == 0 && tempList.size() == k && checkListHasDups(tempList))
        {
            list.add(new ArrayList<>(tempList));
        }
        if(remain < 0 || tempList.size() >= k)
            return;
        else
        {
            for(int i=start;i<9;i++){
                tempList.add(i);
                combinationSumHelper3(list, tempList, k, remain - i, start);
                tempList.remove(tempList.size() - 1);
            }
        }
    }
    private boolean checkListHasDups(List<Integer> tempList){
        HashSet<Integer> hash = new HashSet<Integer>(tempList);
        if(hash.size() < tempList.size())
            return false;
        else
            return true;
    }

    public List<List<Integer>> subsets(int[] nums) {
        Arrays.sort(nums);
        List<List<Integer>> list = new ArrayList<>();
        subsetsHelper(nums, list, new ArrayList<>(), 0);
        return list;
    }
    public void subsetsHelper(int[] nums, List<List<Integer>> list, List<Integer> tempList, int start){

        if(start > nums.length)
            return;
        if(tempList.size() > 0 && list.contains(tempList))
            list.add(new ArrayList<>(tempList));
        for(int i=start;i<nums.length;i++){
            tempList.add(nums[i]);
            subsetsHelper(nums, list, tempList, i+1);
            tempList.remove(tempList.size() - 1);
        }
    } 
    
}