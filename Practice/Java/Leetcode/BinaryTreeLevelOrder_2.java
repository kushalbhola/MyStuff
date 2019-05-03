//https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
package Leetcode;
import java.util.*;
class BinaryTreeLevelOrder_2 {
    public List<List<Integer>> levelOrderBottom(TreeNode root) {

        /*
        Example:
             3
            / \
            9 20
               / \
              15  7
        
        stack: 7, 15, 9
        tempList: {20, 7}
        list:{{3}, {20, 7}}
        size: 2
        */
        List<List<Integer>> list = new ArrayList<>();
        Queue<TreeNode> queue = new LinkedList<TreeNode>();
        Stack<List<Integer>> stack = new Stack<List<Integer>>();
        
        queue.add(root);
        while(queue.size() != 0){
            List<Integer> tempList = new ArrayList<Integer>();
            int size = queue.size();
            for(int i=0;i<size;i++){
                TreeNode temp = queue.poll();
                tempList.add(temp.val);
                if(temp.left != null) queue.add(temp.left);
                if(temp.right != null) queue.add(temp.right);
            }
            stack.push(tempList);
        }
        while(!stack.isEmpty())
            list.add(stack.pop());
        
        return list;
    }
}
