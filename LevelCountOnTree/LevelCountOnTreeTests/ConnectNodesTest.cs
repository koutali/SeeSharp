using System.Runtime.InteropServices.ComTypes;
using LevelCountOnTree;
using Xunit;

namespace LevelCountOnTreeTests
{
    public class ConnectNodesTest
    {
        [Fact]
        public void Test1()
        {
            var root = new Node()
            {
                val = -1,
                left = new Node()
                {
                    val = 0,
                    left = new Node()
                    {
                        val = 2,
                        left = new Node()
                        {
                            val = 6,
                        },
                        right = new Node()
                        {
                            val = 7
                        },
                        next = null
                    },
                    right = new Node()
                    {
                        val = 3,
                        left = new Node()
                        {
                            val = 8
                        },
                        right = new Node()
                        {
                            val = 9
                        },
                        next = null
                    },
                    next = null
                },
                right = new Node()
                {
                    val = 1,
                    left = new Node()
                    {
                        val = 4,
                        left = new Node()
                        {
                            val = 10
                        },
                        right = new Node()
                        {
                            val = 11
                        },
                        next = null
                    },
                    right = new Node()
                    {
                        val = 5,
                        left = new Node()
                        {
                            val = 12
                        },
                        right = new Node()
                        {
                            val = 13
                        },
                        next = null
                    },
                    next = null
                },
                next = null
            };

            var returned = ConnectNodes.Connect(root);
        }
    }
}
