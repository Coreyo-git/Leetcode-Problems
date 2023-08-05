using System.Diagnostics;

public class Solution
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

	public bool LeafSimilar(TreeNode root1, TreeNode root2)
	{


		return false;
	}

	public void traverseForLeafSequence(TreeNode root, List<int> leafSequence)
	{

	}

	public static void Main(string[] args)
	{
		Solution LeafSequenceChecker = new Solution();

		// Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], 
		// 		  root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
		// Output: true

		TreeNode root1_1 = new TreeNode(3);
		root1_1.left = new TreeNode(5);
		root1_1.left.left = new TreeNode(6);
		root1_1.left.right = new TreeNode(2);
		root1_1.left.right.left = new TreeNode(7);
		root1_1.left.right.right = new TreeNode(4);
		root1_1.right = new TreeNode(1);
		root1_1.right.left = new TreeNode(9);
		root1_1.right.right = new TreeNode(8);

		TreeNode root1_2 = new TreeNode(3);
		root1_2.left = new TreeNode(5);
		root1_2.left.left = new TreeNode(6);
		root1_2.left.right = new TreeNode(7);
		root1_2.right = new TreeNode(1);
		root1_2.right.left = new TreeNode(4);
		root1_2.right.right = new TreeNode(2);
		root1_2.right.right.left = new TreeNode(9);
		root1_2.right.right.right = new TreeNode(8);

		bool test1Output = LeafSequenceChecker.LeafSimilar(root1_1, root1_2);
		bool test1Expected = true;
		Debug.Assert(test1Output, formatTestErrorMessage<bool>("1", test1Expected, test1Output));

		// Input: root1 = [1,2,3], 
		// 		  root2 = [1,3,2]
		// Output: false

		TreeNode root2_1 = new TreeNode(1);
		root2_1.left = new TreeNode(2);
		root2_1.right = new TreeNode(3);

		TreeNode root2_2 = new TreeNode(1);
		root2_2.left = new TreeNode(3);
		root2_2.right = new TreeNode(2);

		bool test2Output = LeafSequenceChecker.LeafSimilar(root2_1, root2_2);
		bool test2Expected = false;
		Debug.Assert(!test2Output, formatTestErrorMessage<bool>("2", test2Expected, test2Output));
	}

	/// <summary>
	/// Formats the error message for a test case by including the test name, expected result, and actual result.
	/// </summary>
	/// <param name="test">The name or description of the test case.</param>
	/// <param name="expected">The expected result of the test case.</param>
	/// <param name="actual">The actual result obtained during the test case.</param>
	/// <returns>A formatted error message that includes the test case details.</returns>
	public static string formatTestErrorMessage<T>(string test, T expected, T actual)
	{
		if (typeof(T).IsArray && typeof(T).GetElementType() == typeof(int))
		{
			int[] expectedArray = (int[])(object)expected!;
			int[] actualArray = (int[])(object)actual!;

			string expectedString = "[" + string.Join(", ", expectedArray!) + "]";
			string actualString = "[" + string.Join(", ", actualArray!) + "]";

			return $"-----\nTest {test} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
		}

		else
		{
			string expectedString = expected?.ToString() ?? "null";
			string actualString = actual?.ToString() ?? "null";

			return $"-----\nTest {test} Failed\nExpected: {expectedString}\nActual: {actualString}\n-----";
		}
	}
}