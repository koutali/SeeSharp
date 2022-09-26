namespace TotalFruit
{
    public class FruitSum
    {
        public static int TotalFruit(int[] fruits)
        {
            var maxLength = 0;
            var end = 0;
            var start = 0;

            var fruitByLastSeenIndex = new Dictionary<int, int>();
            while(end < fruits.Length)
            {
                if (!fruitByLastSeenIndex.ContainsKey(fruits[end]))
                {
                    fruitByLastSeenIndex.Add(fruits[end], end);
                }
                else
                {
                    fruitByLastSeenIndex[fruits[end]] = end;
                }

                if (fruitByLastSeenIndex.Count >= 3)
                {
                    var itemToRemove = fruitByLastSeenIndex.OrderBy(x => x.Value).First();
                    
                    var keyToRemove = itemToRemove.Key;
                    var indexOfRemovedItem = itemToRemove.Value;

                    fruitByLastSeenIndex.Remove(keyToRemove);
                    start = indexOfRemovedItem + 1;
                }

                maxLength = Math.Max(maxLength, end - start + 1);
                end++;
            }

            return maxLength;
        }
    }
}