//https://leetcode.com/problems/binary-tree-level-order-traversal/
package Leetcode;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

class BinaryTreeLevelOrder {
    public List<List<Integer>> levelOrder(TreeNode root) {
        List<List<Integer>> result = new ArrayList<>();
        if(root == null)
            return result;
        else {
            Queue<TreeNode> queue = new LinkedList<TreeNode>();
            queue.add(root);
            while(queue.size() != 0){
                int size = queue.size();
                List<Integer> list = new ArrayList<>();
                
                for(int i=0;i<size;i++){
                    TreeNode temp = queue.poll();
                    list.add(temp.val);
                    if(temp.left != null) 
                        queue.add(temp.left);
                    if(temp.right != null) 
                        queue.add(temp.right);
                }
                result.add(new ArrayList<>(list));
            }
            return result;
        }
    }

}
class TreeNode{
    int val;
    TreeNode left;
    TreeNode right;
    TreeNode(int x){
        val = x;
    }
}