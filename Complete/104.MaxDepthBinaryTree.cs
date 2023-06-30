using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

public class MaximumDepthOfBinaryTree
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

	public static int MaxDepth(TreeNode root) {
		// store max depth of tree
		int max = 0;
		if (root == null) return max;
		
		// stores the nodes of the binary tree during BFS
		Queue<TreeNode> NodeQueue = new Queue<TreeNode>();
		
		// queue root at start of queue
		NodeQueue.Enqueue(root);
		
		// iterative solution ensures all nodes are queued and processed before 
		// returning max
		while (NodeQueue.Count > 0)
		{
			// number of nodes on current level
			int size = NodeQueue.Count;

			// iterate over each node at current level
			for (int i = 0; i < size; i++)
			{
				// dequeue current
				TreeNode node = NodeQueue.Dequeue();

				// enqueue left and right nodes if they exist
				if (node.left != null) NodeQueue.Enqueue(node.left);
				if (node.right != null) NodeQueue.Enqueue(node.right);
			}
			// increment max for each level processed till queue is empty
			max++;
		}

		return max;
    }

	
	public static void Main(string[] args)
	{
		// Input: root = [3,9,20,null,null,15,7]
		// Output: 3

		TreeNode root1 = new TreeNode(3);
		root1.left = new TreeNode(9);
		root1.right = new TreeNode(20);
		root1.right.left = new TreeNode(15);
		root1.right.right = new TreeNode(7);

		// Input: root = [1,null,2]
		// Output: 2
		TreeNode root2 = new TreeNode(1);
		root2.right = new TreeNode(2);

		Debug.Assert(MaxDepth(root1) == 3, "Test 1 Failed");
		Debug.Assert(MaxDepth(root2) == 2, "Test 2 Failed");
	}
}

