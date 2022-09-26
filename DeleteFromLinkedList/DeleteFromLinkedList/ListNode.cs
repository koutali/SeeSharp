namespace DeleteFromLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) 
        {
            val = x;
            next = null;
        }
  
        public void DeleteNode(ListNode node)
        {
            ListNode head = this;
            ListNode previous = null;

            while(head != null)
            {                
                if(head.val == node.val)
                {
                    // some element in the middle
                    if(previous != null)
                    {
                        previous.next = head.next;
                        break;
                    }
                    // start element is to be deleted
                    else
                    {
                        head = null;
                    }
                    
                    break;
                }

                previous = head;
                head = head.next;
            }
        }
    }
}