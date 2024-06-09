using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

public class ConvertSortedArrayToBinarySearchTree
{
	public class TreeNode
	{
		public int? val;
		public TreeNode? left;
		public TreeNode? right;

		public TreeNode(int val)
		{
			this.val = val;
			left = null;
			right = null;
		}
	}

	public static TreeNode SortedArrayToBST(int[] nums) {	
		TreeNode? BTree = addToTree(nums);
		return BTree!;
    }

	public static TreeNode? addToTree(int[] nums)
	{
		if(nums.Length == 0) return null;
		if(nums.Length == 1)
		{
			TreeNode BTree = new TreeNode(nums[0]);
			return BTree;
		}

		int min = 0;
		int max = nums.Length;
		int mid = (min + max) / 2;
		TreeNode node = new TreeNode(nums[mid]);
		node.left = addToTree(nums[min..mid]);
		node.right = addToTree(nums[(mid + 1)..max]);
		return node;
	}
	
	public static void Main(string[] args)
	{
		int[] nums = { -10, -3, 0, 5, 9 };
		int[] nums2 = { 1, 3 };
		
		TreeNode tree1 = SortedArrayToBST(nums);
		TreeNode tree2 = SortedArrayToBST(nums2);
		
		Debug.Assert(tree1.val == 0, "Test Error: tree1.val\nExcpected: 0,\nActual: " + tree1.val.ToString() + "\n");
		Debug.Assert(tree1.left!.val == -3, "Test Error: tree1.left\nExcpected: -3,\nActual: " + tree1.left.val.ToString() + "\n");
		Debug.Assert(tree1.left.left!.val == -10, "Test Error: tree1.left.left\nExcpected: -10,\nActual: " + tree1.left.left.val.ToString() + "\n");
		Debug.Assert(tree1.right!.val == 9, "Test Error: tree1.right\nExcpected: 9,\nActual: " + tree1.right.val.ToString() + "\n");
	}
}

