using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

// Given the root of a binary tree and an integer targetSum, 
// return true if the tree has a root-to-leaf path such that 
// adding up all the values along the path equals targetSum.

// A leaf is a node with no children.

public class PathSum
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

	public static bool HasPathSum(TreeNode root, int targetSum)
	{
		if (root == null)
		{
			return false;
		}

		return true;
	}

	public static void Main(string[] args)
	{
		// Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
		// Output: true
		// Explanation: The root-to-leaf path with the target sum is shown.
		int targetSum1 = 22;
		TreeNode root1 = new TreeNode(5);
		root1.left = new TreeNode(4);
		root1.left.left = new TreeNode(11);
		root1.left.left.left = new TreeNode(7);
		root1.left.left.right = new TreeNode(2);
		root1.right = new TreeNode(8);
		root1.right.left = new TreeNode(13);
		root1.right.right = new TreeNode(4);
		root1.right.right.right = new TreeNode(1);

		// Input: root = [1,2,3], targetSum = 5
		// Output: false
		// Explanation: There two root-to-leaf paths in the tree:
		// (1 --> 2): The sum is 3.
		// (1 --> 3): The sum is 4.
		// There is no root-to-leaf path with sum = 5.
		
		int targetSum2 = 5;
		TreeNode root2 = new TreeNode(1);
		root2.left = new TreeNode(2);
		root2.right = new TreeNode(3);

		// Input: root = [], targetSum = 0
		// Output: false
		// Explanation: Since the tree is empty, there are no root-to-leaf paths.
		
		int targetSum3 = 0;
		TreeNode root3 = new TreeNode(null);
		Debug.Assert(HasPathSum(root1, targetSum1), $"Test 1 root1 Failed\nExpected: true\nActual: false");
		Debug.Assert(!HasPathSum(root1, 0), $"Test 2 root1 Failed\nExpected: false\nActual: true");

		Debug.Assert(HasPathSum(root2, targetSum2), $"Test 3 root2 Failed\nExpected: true\nActual: false");
		Debug.Assert(!HasPathSum(root2, 0), $"Test 4 root2 Failed\nExpected: false\nActual: true");

		Debug.Assert(!HasPathSum(root3, targetSum3), $"Test 5 root3 Failed\nExpected: false\nActual: true");
		Debug.Assert(!HasPathSum(root3, 99), $"Test 6 root3 Failed\nExpected: false\nActual: true");
	}
}

