using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerateParantheses
{
    public class Paranthesis
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            if (n < 0)
                throw new ArgumentException(nameof(n));

            var list = new List<string> {"()"};
            for (var i = 1; i < n; i++)
            {
                var combinations = new HashSet<string>();
                combinations.UnionWith(AddLeft(list));
                combinations.UnionWith(AddRight(list));
                combinations.UnionWith(Surround(list));

                list = combinations.ToList();
            }

            return list;
        }

        private static IEnumerable<string> AddLeft(IEnumerable<string> list)
        {
            var toReturn = new HashSet<string>();
            foreach (var s in list)
            {
                var toAdd = "()" + s; 
                if (!toReturn.Contains(toAdd))
                {
                    toReturn.Add(toAdd);
                }
            }

            return toReturn;
        }

        private static IEnumerable<string> AddRight(IEnumerable<string> list)
        {
            var toReturn = new HashSet<string>();
            foreach (var s in list)
            {
                var toAdd = s + "()"; 
                if (!toReturn.Contains(toAdd))
                {
                    toReturn.Add(toAdd);
                }
            }

            return toReturn;
        }

        private static IEnumerable<string> Surround(IEnumerable<string> list)
        {
            var toReturn = new HashSet<string>();
            foreach (var s in list)
            {
                var toAdd = "(" + s + ")";
                if (!toReturn.Contains(toAdd))
                {
                    toReturn.Add(toAdd);
                }
            }

            return toReturn;
        }
    }
}
