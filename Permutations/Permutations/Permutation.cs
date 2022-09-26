using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    public class Permutation
    {
        #region public
        public IList<IList<int>> PermuteUnique(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentException(nameof(numbers));

            // init output list
            var output = new List<List<int>>();

            // convert nums into list since the output is a list of lists
            var numberList = numbers.ToList();
            Backtrack(numbers.Length, numberList, output, 0);

            var hashSet = new HashSet<List<int>>();
            foreach (var list in output.Distinct())
            {
                if(!hashSet.Contains(list))
                    hashSet.Add(list);
            }

            var ret = new List<IList<int>>();
            foreach (var set in hashSet)
                ret.Add(set.ToList());

            return ret;
        }

        public List<List<int>> Permute(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentException(nameof(numbers));

            // init output list
            var output = new List<List<int>>();

            // convert nums into list since the output is a list of lists
            var numberList = numbers.ToList();
            Backtrack(numbers.Length, numberList, output, 0);

            return output;
        }

        #endregion

        #region private

        private static void Backtrack(int n, IList<int> numbers, ICollection<List<int>> output, int first)
        {
            // if all integers are used up
            if (first == n)
                output.Add(new List<int>(numbers));

            for (var i = first; i < n; i++)
            {
                // place i-th integer first 
                // in the current permutation
                Swap(numbers, first, i);

                // use next integers to complete the permutations
                Backtrack(n, numbers, output, first + 1);

                // backtrack
                Swap(numbers, first, i);
            }
        }

        private static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            var tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        #endregion
    }
}
