using System.Linq;

namespace RemoveDuplicatesFromSortedArray
{
    public class RemoveDuplicatesClass
    {
        public static int RemoveDuplicates(int[] nums)
        {
            nums = nums.Distinct().ToArray();
            return nums.Length;
        }
    }
}
