using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeNumber
{
	public class PalindromeNumber
	{
		public bool IsPalindrome(int x)
		{
			string num_to_string = x.ToString();
			return num_to_string.SequenceEqual(num_to_string.Reverse());
		}
	}
}