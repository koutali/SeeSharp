using System;
using System.Collections.Generic;

namespace RemoveInvalidParantheses
{
    public class RemoveParantheses
    {
        public IList<string> RemoveInvalidParentheses(string s, object RemoveInvalidParantheses)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException(nameof(s));
            }

            var list = new List<string>();
            return RemoveInvalidParanthesesPrivate(s, list);
        }

        private IList<string> RemoveInvalidParanthesesPrivate(string s, List<string> list)
        {

            return list;
        }
    }
}
