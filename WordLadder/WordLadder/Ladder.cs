using System.Collections.Generic;
using System.Linq;

namespace WordLadder
{
    public class Ladder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (wordList.FirstOrDefault(x => x.Equals(endWord)) == null)
            {
                return 0;
            }

            var allWords = GetAllWords(beginWord, endWord, wordList);
            var adjacencyMatrix = InitializeAdjacencyMatrix(allWords);

            var distance = InitializeDistancesToStart(adjacencyMatrix);

            Bfs(0, adjacencyMatrix, distance);

            if (distance.Last() == int.MaxValue)
            {
                return 0;
            }

            return distance.Last() + 1;
        }

        private void Bfs(int startNode, int[,] adjacencyMatrix, IList<int> distance)
        {
            distance[startNode] = 0;

            var queue = new Queue<int>();
            queue.Enqueue(startNode);

            while (queue.Any())
            {
                var node = queue.Dequeue();

                for (var neighbor = 0; neighbor < adjacencyMatrix.GetLength(1); neighbor++)
                {
                    if (adjacencyMatrix[node, neighbor] == 0)
                    {
                        continue;
                    }

                    if (distance[neighbor] != int.MaxValue)
                        continue;

                    distance[neighbor] = distance[node] + 1;
                    queue.Enqueue(neighbor);
                }
            }
        }

        private static int[] InitializeDistancesToStart(int[,] adjacencyMatrix)
        {
            var distance = new int[adjacencyMatrix.GetLength(0)];
            for (var i = 0; i < distance.Length; i++)
            {
                distance[i] = int.MaxValue;
            }

            return distance;
        }

        private static List<string> GetAllWords(string beginWord, string endWord, IEnumerable<string> wordList)
        {
            var allWords = new List<string> { beginWord };

            foreach (var word in wordList)
            {
                if (word.Equals(endWord) || word.Equals(beginWord))
                {
                    continue;
                }

                allWords.Add(word);
            }


            allWords.Add(endWord);
            return allWords;
        }

        private static int[ , ] InitializeAdjacencyMatrix(IList<string> wordList)
        {
            var adjacencyMatrix = new int[wordList.Count, wordList.Count];

            for (var i = 0; i < wordList.Count; i++)
            {
                for (var j = i + 1; j < wordList.Count; j++)
                {
                    var differentChars = CountDifferentChars(wordList[i], wordList[j]);
                    if (differentChars != 1)
                        continue;

                    adjacencyMatrix[i, j] = 1;
                    adjacencyMatrix[j, i] = 1;
                }
            }

            return adjacencyMatrix;
        }

        private static int CountDifferentChars(string firstWord, string secondWord)
        {
            return firstWord.Where((t, i) => t != secondWord[i]).Count();
        }
    }
}
