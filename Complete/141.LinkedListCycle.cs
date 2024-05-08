using Leetcode.Types;
using static Leetcode.TestUtils;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Leetcode
{
    public class Solution
    {
        public static bool hasCycle(ListNode head)
        {
            // Check if the list is empty, return false as an empty list cannot have a cycle
            if (head == null) 
                return false;

            // setup two pointers to step through the list at different rates
            // pointerOne moves one step at a time (slow)
            // pointerTwo moves two steps at a time (fast)
            ListNode pointerOne = head;
            ListNode pointerTwo = head;

            // Loop through the list as long as pointerTwo and pointerTwo's next node are not null
            while (pointerTwo != null && pointerTwo.next != null) {
                // Move pointerOne one step forward.
                pointerOne = pointerOne.next;
                // Move pointerTwo two steps forward.
                pointerTwo = pointerTwo.next.next;

                // Check if the two pointers meet, indicates a cycle.
                if (pointerOne == pointerTwo)
                    // If they meet, return true indicating that there is a cycle.
                    return true; 
            }

            // If pointerTwo reaches the end and is null, it means there is no cycle, breaks and returns false.
            return false;
        }

        public static void Main(string[] args)
        {
            // Input: head = [3, 2, 0, -4], pos = 1
            // Output: true
            // Explanation: There is a cycle in the linked list, where the tail connects to the 1st node(0 - indexed).

            // Setup list1 
            ListNode list1 = new ListNode([3, 2, 0, -4]);
            
            // setup cycle from end (-4) to pos 1 (2)
            list1.next.next.next.next = list1.next;

            bool test1Output = hasCycle(list1);
            bool test1Expected = true;

            Debug.Assert(test1Output.Equals(test1Expected), formatTestErrorMessage<bool>(1, test1Expected, test1Output));

            // Input: head = [1, 2], pos = 0
            // Output: true
            // Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
            // Setup list1 
            ListNode list2 = new ListNode([1,2]);

            // setup cycle from end (2) to pos 1 (1)
            list2.next.next = list2;

            bool test2Output = hasCycle(list2);
            bool test2Expected = true;

            Debug.Assert(test2Output.Equals(test2Expected), formatTestErrorMessage<bool>(2, test2Expected, test2Output));

            // Input: head = [1], pos = -1
            // Output: false
            // Explanation: There is no cycle in the linked list.
            ListNode list3 = new ListNode([1, 2]);

            bool test3Output = hasCycle(list3);
            bool test3Expected = false;

            Debug.Assert(test3Output.Equals(test3Expected), formatTestErrorMessage<bool>(3, test3Expected, test3Output));
        }
    }
}
