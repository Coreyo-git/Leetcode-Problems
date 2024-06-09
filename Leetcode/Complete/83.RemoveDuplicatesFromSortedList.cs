public class RemoveDuplicatesFromSortedList {
	public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;
        ListNode start = head;

        while(head.next != null)
        {
            while(head.next.next != null && head.val == head.next.val)
            {
                head.next = head.next.next;
            }
            if(head.val == head.next.val) head.next = null;
            else head = head.next;
        }

        return start;
    }
}