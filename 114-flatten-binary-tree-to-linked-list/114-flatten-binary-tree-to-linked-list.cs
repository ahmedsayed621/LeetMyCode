/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public void Flatten(TreeNode root) {
        if (root == null)
            return;
        
        TreeNode tempNode = null,
                 lastNode = null;
        
        Flatten(root.left);
        Flatten(root.right);
        
        if (root.left != null)
        {
            tempNode = root.right;
            root.right = root.left;
            root.left = null;
            lastNode = root.right;
            
            while (lastNode.right != null)
                lastNode = lastNode.right;
                
            lastNode.right = tempNode;
        }
    }
}