using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoSum
{
	public class TwoSum
	{
		int[] TwoSum(int[] nums, int target)
		{
			int[] results = new int[2];

			// i stores the current number being added too
			for (int i = 0; i < nums.Length; i++)
			{
				// j stores the number being added
				for (int j = i + 1; j < nums.Length; j++)
				{

					if (nums[i] + nums[j] == target)
					{
						results[0] = i;
						results[1] = j;
						return results;
					}
				}
			}
			return results;
		}
	}
}