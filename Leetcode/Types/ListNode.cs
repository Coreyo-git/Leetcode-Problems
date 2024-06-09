using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Leetcode.Types
{
    //  Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
        
        // Construct from an array of values
        public ListNode(int[] values)
        {
            // catch null or empty array and throw an arugment
            if (values == null || values.Length == 0)
                throw new ArgumentException("Array must contain at least one element");

            // Set up the head of the list
            val = values[0];
            ListNode current = this;

            // loop through the rest of the values creating new ListNodes starting from the second element
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
        }
    }


}
