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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null)
            return new List<IList<int>>();
        
        int sizeInLevel = 0;
        IList<IList<int>> results = new List<IList<int>>();
        IList<int> resultInLevel = null;
        Queue<TreeNode> level = new Queue<TreeNode>();
        TreeNode currentNode = null;
        
        level.Enqueue(root);
        
        while (level.Count != 0)
        {
            sizeInLevel = level.Count;
            resultInLevel = new List<int>();
            
            while (sizeInLevel != 0)
            {
                currentNode = level.Dequeue();
                
                if (currentNode.left != null)
                    level.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    level.Enqueue(currentNode.right);
                
                resultInLevel.Add(currentNode.val);
                sizeInLevel--;
            }
            
            results.Add(resultInLevel);
        }
        
        return results;
    }
}