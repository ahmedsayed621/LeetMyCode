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
enum CameraState { Covered, Camera, Required }
public int MinCameraCover(TreeNode root) 
{
	int camerasRequired = 0;
	CameraState CameraCover(TreeNode current)
	{
		if(current == null) return CameraState.Covered;

		var left = CameraCover(current.left);
		var right = CameraCover(current.right);

		if(left == CameraState.Required || right == CameraState.Required)
		{
			camerasRequired++;
			return CameraState.Camera;
		}
		else if (left == CameraState.Camera || right ==  CameraState.Camera)
		{
			return CameraState.Covered;
		}

		return CameraState.Required;
	}

	var state = CameraCover(root);
	if(state == CameraState.Required) { camerasRequired++; }
	return camerasRequired;
}
}