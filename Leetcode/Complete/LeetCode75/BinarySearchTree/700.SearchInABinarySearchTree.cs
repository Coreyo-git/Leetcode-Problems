using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

// You are given the root of a binary search tree (BST) and an integer val.

// Find the node in the BST that the node's value equals val and return the subtree rooted with that node. 
// If such a node does not exist, return null.

public class Solution
{
	public class TreeNode
	{
		public int val;
		public TreeNode? left;
		public TreeNode? right;

		public TreeNode(int val)
		{
			this.val = val;
			left = null;
			right = null;
		}
	}

	// search for a value in a Binary Search Tree
	public TreeNode SearchBST(TreeNode root, int val)
	{
		// If root is null return null
		if (root == null) return null;

		// If value is found at current, return the root
		if (val == root.val) return root;

		// If value is greater than current value, search right subtree
		if (val > root.val) return SearchBST(root.right, val);

		// If value is less than current value, search left subtree
		else return SearchBST(root.left, val);
	}


	public static void Main(string[] args)
	{
		Solution search = new Solution();

		TreeNode root = new TreeNode(4);
		root.left = new TreeNode(2);
		root.right = new TreeNode(7);
		root.left.left = new TreeNode(1);
		root.left.right = new TreeNode(3);

		// Input: root = [4,2,7,1,3], val = 2
		// Output: [2,1,3]
		Debug.Assert(search.SearchBST(root, 2) == root.left, "Test 1 Failed");

		// Input: root = [4,2,7,1,3], val = 5
		// Output: []
		Debug.Assert(search.SearchBST(root, 5) == null, "Test 2 Failed");
	}
}
