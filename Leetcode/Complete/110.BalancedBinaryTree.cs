using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

public class BalancedBinaryTree
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

	public static bool IsBalanced(TreeNode root)
	{
		if (root == null) return true;

		(bool isBalanced, int height) result = dfs(root);
		
		return result.isBalanced;
	}

	private static (bool isBalanced, int height) dfs(TreeNode node)
	{
		if (node == null)
			return (true, 0);

		(bool isLeftBalanced, int leftHeight) = dfs(node.left!);
		(bool isRightBalanced, int rightHeight) = dfs(node.right!);

		bool balanced = isLeftBalanced && isRightBalanced && Math.Abs(leftHeight - rightHeight) <= 1;
		int height = 1 + Math.Max(leftHeight, rightHeight);

		return (balanced, height);
	}

	public static void Main(string[] args)
	{
		// Input: root = [3,9,20,null,null,15,7]
		// Output: true

		TreeNode root1 = new TreeNode(3);
		root1.left = new TreeNode(9);
		root1.right = new TreeNode(20);
		root1.right.left = new TreeNode(15);
		root1.right.right = new TreeNode(7);

		// Input: root = [1,2,2,3,3,null,null,4,4]
		// Output: false

		TreeNode root2 = new TreeNode(1);
		root2.right = new TreeNode(2);
		root2.left  = new TreeNode(2);
		root2.left.left = new TreeNode(3);
		root2.left.right = new TreeNode(3);
		root2.left.left.left = new TreeNode(4);
		root2.left.left.right = new TreeNode(4);
		

		// Input: root = []
		// Output: true

		TreeNode root3 = new TreeNode(null);

		Debug.Assert(IsBalanced(root1) == true, "Test 1 Failed");
		Debug.Assert(IsBalanced(root2) == false, "Test 2 Failed");
		Debug.Assert(IsBalanced(root3) == true, "Test 1 Failed");
	}
}

