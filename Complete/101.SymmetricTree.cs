using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

public class SymmetricTree
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

	public static bool isSymmetric(TreeNode root)
	{
		if (root != null) return traverse(root.left!, root.right!);
		else return true;
	}

	public static bool traverse(TreeNode left, TreeNode right)
	{
		if(left == null && right == null) return true;
		if(left == null || right == null) return false;
		if(left!.val != right!.val) return false;
		return traverse(left.left!, right.right!) && traverse(left.right!, right.left!); 
	}

	public static void Main(string[] args)
	{
		TreeNode root1 = new TreeNode(1);
		root1.left = new TreeNode(2);
		root1.left.left = new TreeNode(3);
		root1.left.right = new TreeNode(4);

		root1.right = new TreeNode(2);
		root1.right.left = new TreeNode(4);
		root1.right.right = new TreeNode(3);
		

		TreeNode root2 = new TreeNode(1);
		root2.left = new TreeNode(2);
		root2.left.right = new TreeNode(3);
		root2.right = new TreeNode(2);
		root2.right.right = new TreeNode(3);

		TreeNode root3 = new TreeNode(1);
		root3.left = new TreeNode(0);


		Debug.Assert(isSymmetric(root1), "Test 1 Failed");
		Debug.Assert(!isSymmetric(root2), "Test 2 Failed");
		Debug.Assert(!isSymmetric(root3), "Test 3 Failed");
	}
}

