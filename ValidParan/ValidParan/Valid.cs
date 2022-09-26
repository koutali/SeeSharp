using System.Collections.Generic;
using System.Linq;

namespace ValidParan
{
    public class Valid
    {
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                char popped;
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(c);
                        break;

                    case ')':
                        if (!stack.Any())
                            return false;

                        popped = stack.Pop();
                        if (popped != '(')
                            return false;
                        
                        break;
                    
                    case ']':
                        if (!stack.Any())
                            return false;

                        popped = stack.Pop();
                        if (popped != '[')
                            return false;

                        break;

                    case '}':

                        if (!stack.Any())
                            return false;

                        popped = stack.Pop();
                        if (popped != '{')
                            return false;

                        break;

                    default:
                        return false;

                }
            }

            return !stack.Any();
        }
    }
}
