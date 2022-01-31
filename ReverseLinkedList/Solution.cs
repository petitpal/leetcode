using System.Collections.Generic;

public class Solution {

    public ListNode ReverseList(ListNode head) => ReverseList_Itterate(head);


    ListNode ReverseList_Itterate(ListNode head) {
        if (head==null || head.next==null) return head;

        ListNode prev = null;
        ListNode next;

        while (head!=null)
        {
            // save the next item
            next = head.next;

            // adjust the current node to point at the previous one
            head.next = prev;

            // the next node will need to point at this one
            prev = head;

            // move onto the next item in the list
            if (next == null)
                return head;
            else
                head = next;
        }

        return null;
    }

    ListNode ReverseList_Stack(ListNode head) {
        if (head==null || head.next==null) return head;

        var items = new Stack<ListNode>();
        var item = head;

        // stack items (LIFO)
        while (item!=null)
        {
            items.Push(item);
            item = item.next;
        }

        // head is now first item
        head = items.Peek();
        
        // adjust pointers
        while (items.TryPop(out item))
        {
            items.TryPeek(out item.next);
        }

        return head;
    }
}