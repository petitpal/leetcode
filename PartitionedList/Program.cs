using System;

namespace PartitionedList
{
    class Program
    {
        static void Main(string[] args)
        {           
            // [1,4,3,2,5,2]
            
            var x = 3;
            ListNode h1 = new(1,null);
            ListNode h2 = new(4,null);
            ListNode h3 = new(3,null);
            ListNode h4 = new(2,null);
            ListNode h5 = new(5,null);
            ListNode h6 = new(2,null);
            h1.next=h2;
            h2.next=h3;
            h3.next=h4;
            h4.next=h5;
            h5.next=h6;

            var output = Partition(h1, x);
            var ctrlBreak = "";
        }


        
         public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode Partition(ListNode head, int x) {
            
            ListNode h = null;
            ListNode l = null;
            ListNode r = null;
            
            while (head!=null)
            {
                if (head.val >= x)
                {
                    if (r!=null)
                    {
                        r.next = head;
                    }
                    r = head;
                }
                else
                {
                    if (l!=null)
                    {
                        l.next = head;
                    }

                    l = head;
                    if (h==null) {
                        h=l;
                    }
                }
                
                head = head.next;
            }
            
            if (l !=null && r !=null) {
                l.next = r;
            }
            
            return h;
        }
    }
}
