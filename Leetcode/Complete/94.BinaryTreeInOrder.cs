using System;

class TreeNode
{
	public int val;
	public TreeNode? left, right;

	public TreeNode(int val)
	{
		this.val = val;
		left = right = null;
	}
}

class Solution
{
	public IList<int> InorderTraversal(TreeNode root)
	{
		IList<int> res = new List<int>();
		TraversalHelper(root, res);
		return res;

	}
	public void TraversalHelper(TreeNode root, IList<int> res)
	{
		if (root == null) return;
		if (root.left != null) TraversalHelper(root.left, res);
		res.Add(root.val);
		if (root.right != null) TraversalHelper(root.right, res);
	}
	public static void Main(string[] args)
	{

	}
}