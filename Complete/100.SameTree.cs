using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;



public class SameTree
{
	public class TreeNode
	{
		public int val;
		public TreeNode? left, right;

		public TreeNode(int val)
		{
			this.val = val;
			left = right = null;
		}
	}
	public static bool IsSameTree(TreeNode p, TreeNode q)
	{
		if (p == null && q == null) return true;
		if (p == null || q == null) return false;
		if (p.val != q.val) return false;

		bool lCheck = IsSameTree(p.left!, q.left!);
		bool rCheck = IsSameTree(p.right!, q.right!);

		return lCheck && rCheck;
	}

	public static void Main(string[] args)
	{
		TreeNode root1 = new TreeNode(1);
		root1.left = new TreeNode(2);
		root1.right = new TreeNode(3);

		TreeNode root2 = new TreeNode(1);
		root2.left = new TreeNode(2);

		TreeNode root3 = new TreeNode(1);
		root3.right = new TreeNode(2);

		TreeNode root4 = new TreeNode(1);
		root4.left = new TreeNode(2);
		root4.right = new TreeNode(1);

		TreeNode root5 = new TreeNode(1);
		root5.left = new TreeNode(1);
		root5.right = new TreeNode(2);

		Debug.Assert(IsSameTree(root1, root1), "Test 1 Failed");
		Debug.Assert(!IsSameTree(root2, root3), "Test 2 Failed");
		Debug.Assert(!IsSameTree(root4, root5), "Test 3 Failed");
	}
}

