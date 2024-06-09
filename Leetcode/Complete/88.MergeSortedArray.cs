using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
	public class MergeSortedArray
	{
		public static void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			if (nums1.Length == 0)
			{
				nums1 = nums2;
				return;
			}
			int total = m + n;
			int[] temp = new int[m];
			Array.Copy(nums1, temp, m);

			int index1 = 0;
			int index2 = 0;

			for (int i = 0; i < total; i++)
			{
				System.Console.WriteLine("index1: " + index1 + " | index2: " + index2);
				if (index1 == m)
				{
					nums1[i] = nums2[index2];
					index2++;
					continue;
				}
				if (index2 == n)
				{
					nums1[i] = temp[index1];
					index1++;
					continue;
				}
				if (temp[index1] < nums2[index2])
				{
					nums1[i] = temp[index1];
					index1++;
					continue;
				}
				else
				{
					nums1[i] = nums2[index2];
					index2++;
					continue;
				}
			}
			for (int i = 0; i < nums1.Length; i++)
			{
				Console.WriteLine(nums1[i]);
			}
		}
		public static void Main(string[] args)
		{
			int[] nums1 = { 1, 2, 3, 0, 0, 0 };
			int m = 3;
			int[] nums2 = { 2, 5, 6 };
			int n = 3;
			MergeSortedArray.Merge(nums1, m, nums2, n);
		}
	}
}