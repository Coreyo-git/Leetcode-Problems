using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

// Given a root node reference of a BST and a key, delete the node with the given key in the BST. 
// Return the root node reference (possibly updated) of the BST.

// Basically, the deletion can be divided into two stages:
//     1. Search for a node to remove.
//     2. If the node is found, delete the node.

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

	// search for a key in a Binary Search Tree and delete it
	public TreeNode DeleteNode(TreeNode root, int key)
	{
		// If root is null return null
		if (root == null) return null;

		// If value is greater than current value, search right subtree
		else if (key > root.val) root.right = DeleteNode(root.right, key);

		// If value is less than current value, search left subtree
		else if (key < root.val) root.left = DeleteNode(root.left, key);

		// If value is found at current, swap with subtree left, right or null
		else
		{
			if (root.left == null && root.right == null)
			{
				root = null;
			}
			// has either no left child or no right child
			else if (root.left == null || root.right == null)
			{
				// ret = non-null child.
				TreeNode ret = root.left != null ? root.left : root.right;
				root = ret;
			}
			// node has two children
			else
			{
				// init temp to hold right child
				TreeNode tmp = root.right;

				// traverse right subtree for min
				while (tmp.left != null)
				{
					tmp = tmp.left;
				}
				// replace with min value in right subtree
				root.val = tmp.val;

				// recurse to delete min values (duplicates)
				root.right = DeleteNode(root.right, tmp.val);
			}
		}

		return root;
	}


	public static void Main(string[] args)
	{
		Solution delete = new Solution();

		TreeNode root = new TreeNode(5);
		root.left = new TreeNode(3);
		root.right = new TreeNode(6);
		root.left.left = new TreeNode(2);
		root.left.right = new TreeNode(4);
		root.right.right = new TreeNode(7);

		// Input: root = [5,3,6,2,4,null,7], key = 3
		// Output: [5,4,6,2,null,null,7]
		// Explanation: Given key to delete is 3. So we find the node with value 3 and delete it.
		//   One valid answer is [5,4,6,2,null,null,7], shown in the above BST.
		//   Please notice that another valid answer is [5,2,6,null,4,null,7] and it's also accepted.
		delete.DeleteNode(root, 3);
		Debug.Assert(root.left.val == 4 || root.left.val == 2, "Test 1 Failed, val: " + root.left.val);
	}
}
