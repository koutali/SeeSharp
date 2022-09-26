using System.Text;

//Algorithm:
//1.Convert Infix to PostFix
//2.Convert Post fix string to exp tree
//Operator Precedence: 
//	1. (
//    2. * /
//    3. + -
//Associativity is left->right for all operators above

namespace BuildBinaryExpressionTreeFromInfix
{
    public class BuildBinaryExpressionTreeFromInfix
    {
        //2.Convert Post fix string to exp tree
        //    foreach c in s 
        //        if c is number
        //            stack.Push(new Node(c));
        //        else
        //    var node = new Node(c);
        //node.right = stack.Pull()
        //            node.left = stack.Pull()
        //            stack.Push(node)
        public Node ExpTree(string s)
        {
            string postStr = getPostFix(s);
            Console.WriteLine(postStr);
            Stack<Node> stack = new();

            for (int i = 0; i < postStr.Length; i++)
            {
                char c = postStr[i];
                if (char.IsNumber(c))
                {
                    stack.Push(new Node(c));
                }
                else
                {
                    var optNode = new Node(c);
                    optNode.right = stack.Pop();
                    optNode.left = stack.Pop();
                    stack.Push(optNode);
                }
            }

            return stack.Pop();
        }

        //1.Convert Infix to PostFix
        //    foreach c in s
        //        if c is number
        //            Append to postFixStr
        //        if c is operator
        //            while(c has operators which are higher is precedence || higher in associativity)
        //                postFixStr.Append(stack.Pull());
        //stack.Post(c);
        private string getPostFix(string infixInput)
        {
            Stack<char> stack = new();
            StringBuilder postFixOutput = new();
            for (int i = 0; i < infixInput.Length; i++)
            {
                char c = infixInput[i];
                // Console.WriteLine(c);
                if (char.IsNumber(c))
                {
                    postFixOutput.Append(c);
                }
                else if (c == '(')
                    stack.Push(c);
                else if (c == '*' || c == '/')
                {
                    while (stack.Count > 0 && (stack.Peek() == '*' || stack.Peek() == '/'))
                    {
                        postFixOutput.Append(stack.Pop());
                    }
                    stack.Push(c);
                }
                else if (c == '+' || c == '-')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postFixOutput.Append(stack.Pop());
                    }
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postFixOutput.Append(stack.Pop());
                    }
                    stack.Pop();
                }
                else
                {
                    throw new Exception("unknown identifier");
                }
            }
            while (stack.Count > 0)
            {
                postFixOutput.Append(stack.Pop());
            }
            return postFixOutput.ToString();
        }
    }
}