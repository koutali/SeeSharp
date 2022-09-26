using System.Collections.Generic;
using System.Linq;

namespace _3Sum
{
    public class Combination
    {
        public int First;
        public int Second;
        public int Third;

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || GetType() != obj.GetType())
            {
                return false;
            }

            var p = (Combination)obj;
            var firstList = new List<int> { p.First, p.Second, p.Third }.OrderBy(x => x).ToList();
            var secondList = new List<int> { First, Second, Third }.OrderBy(x => x).ToList();

            return firstList.SequenceEqual(secondList);
        }

        public override int GetHashCode()
        {
            return First + Second + Third;
        }
    }
}