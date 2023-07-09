using System.Runtime.InteropServices;
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
		if (root == null)
			return 0;

		int minDepth = int.MaxValue;
		dfs(root, 1, ref minDepth);

		return minDepth;
	}

	private static void dfs(TreeNode node, int depth, ref int minDepth)
	{
		if (node.left == null && node.right == null)
		{
			minDepth = Math.Min(minDepth, depth);
			return;
		}

		if (node.left != null) dfs(node.left, depth + 1, ref minDepth);

		if (node.right != null) dfs(node.right, depth + 1, ref minDepth);
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

		// Input: root = [1,2,3,4,5]
		// Output: 2
		TreeNode root3 = new TreeNode(1);
		root3.left = new TreeNode(2);
		root3.right = new TreeNode(3);
		root3.left.left = new TreeNode(4);
		root3.left.right = new TreeNode(5);

		int depth1 = MinDepth(root1);
		int depth2 = MinDepth(root2);
		int depth3 = MinDepth(root3);
		Debug.Assert(depth1 == 2, $"Test 1 Failed\nExpected: 2\nActual: {depth1}");
		Debug.Assert(depth2 == 5, $"Test 2 Failed\nExpected: 5\nActual: {depth2}");
		Debug.Assert(depth3 == 2, $"Test 3 Failed\nExpected: 2\nActual: {depth3}");
	}
}

