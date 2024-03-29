/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        if (root == null)
        {
            return null;
        }
        
        if (root.val > p.val && root.val > q.val)
        {
            return LowestCommonAncestor(root.left, p, q);
        }
        
        if (root.val < p.val && root.val < q.val)
        {
            return LowestCommonAncestor(root.right, p, q);
        }
        
        if (root == p)
        {
            return root;
        }
        
        if (root == q)
        {
            return q;
        }
        
        if (root.left != null && root.right != null)
        {
            if (root.left == q && root.right == p || root.left == p && root.right == q)
            {
                return root;
            }
        }
        
        return root;
    }
}