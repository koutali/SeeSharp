namespace BuildBinaryExpressionTreeFromInfix
{

    //Definition for a binary tree node.
    public class Node
    {
        public char val;
        public Node left;
        public Node right;
        public Node(char val = ' ', Node left = null, Node right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
