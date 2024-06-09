using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
	public class MergeTwoSortedLists
	{
		public ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			// return other list if one is null as they're already sorted
			if (list1 == null) return list2;
			if (list2 == null) return list1;

			// create new ListNode head = 0 then a pointer to it
			ListNode newList = new ListNode();
			ListNode pointer = newList;


			// iterate through both lists till one is null
			while (list1 != null && list2 != null)
			{
				// if list1 or list2 val is lower
				// assign the lower to the pointer next
				if (list1.val < list2.val)
				{
					pointer.next = list1;
					list1 = list1.next;
				}
				else
				{
					pointer.next = list2;
					list2 = list2.next;
				}

				// step to next value after comparison complete
				pointer = pointer.next;
			}

			// if one list still has values append it's head as the
			// tail on the new list
			if (list1 != null)
			{
				pointer.next = list1;
			}
			else if (list2 != null)
			{
				pointer.next = list2;
			}

			// newList is the head and = 0, next = the start of our merged sorted list
			return newList.next;
		}
	}
}