namespace AddTwoNumbers
{
    public class ListNode
    {
        #region members

        public int val;
        public ListNode next;
        public int Size = 0;

        #endregion

        #region public

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
            Size += 1;
        }

        public void Insert(int num)
        {
            var current = this;
            while (current?.next != null)
            {
                current = current.next;
            }

            var next = new ListNode(num);
            current.next = next;
            Size++;
        }

        #endregion
    }
}
