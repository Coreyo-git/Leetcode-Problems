using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

public class MinimumDepthOfBinaryTree
{
	public class TreeNode
	{
		public int? val;
		public TreeNode? left;
		public TreeNode? right;

		public TreeNode(int? val)
		{
			this.val = val;
			left = null;
			right = null;
		}
	}

	public static int MinDepth(TreeNode root)
	{
		int depth = 0;
		if (root == null) return depth;

		dfs(root, depth);

		return depth;
	}

	private static void dfs(TreeNode node, int depth)
	{
		if (node == null) return;

		return;
	}

	public static void Main(string[] args)
	{
		// Input: root = [3,9,20,null,null,15,7]
		// Output: 2

		TreeNode root1 = new TreeNode(3);
		root1.left = new TreeNode(9);
		root1.right = new TreeNode(20);
		root1.right.left = new TreeNode(15);
		root1.right.right = new TreeNode(7);

		// Input: root = [2,null,3,null,4,null,5,null,6]
		// Output: 5

		TreeNode root2 = new TreeNode(1);
		root2.right = new TreeNode(2);
		root2.right.right = new TreeNode(4);
		root2.right.right.right = new TreeNode(5);
		root2.right.right.right.right = new TreeNode(6);

		int depth1 = MinDepth(root1);
		int depth2 = MinDepth(root2);
		Debug.Assert(depth1 == 2, $"Test 1 Failed\nExpected: 2\nActual: {depth1}");
		Debug.Assert(depth2 == 5, $"Test 2 Failed\nExpected: 5\nActual: {depth2}");
	}
}

