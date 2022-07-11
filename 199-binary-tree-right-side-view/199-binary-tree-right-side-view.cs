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
    public IList<int> RightSideView(TreeNode root) {
        List<int> result = new List<int>();
        Queue<TreeNode> level = new Queue<TreeNode>();
        int countInLevel = 0;
        TreeNode currentNode = null;
        
        if (root != null)
        {
            level.Enqueue(root);
            
            while (level.Count != 0)
            {
                countInLevel = level.Count;
                
                while (countInLevel > 0)
                {
                    currentNode = level.Dequeue();
                    if (currentNode.left != null)
                        level.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        level.Enqueue(currentNode.right);
                        
                    if (countInLevel == 1)
                        result.Add(currentNode.val);
                    
                    countInLevel--;
                }
            }
        }
        
        return result;
    }
}