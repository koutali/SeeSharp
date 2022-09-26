using KClosestPointsToOrigin;
using Xunit;

namespace ClosestToOriginTests
{
    public class Sort2dArrayTests
    {
        [Fact]
        public void Test1()
        {
            var points = new[]
            {
                new[]{1,3},
                new[]{-2,2}
            };

            var expected = new[]
            {
                new[] { -2, 2 }
            };

            var returned = Sort2dArray.KClosest(points, 1);
            for (var i = 0; i < returned.Length; i++)
            {
                for (var j = 0; j < returned[i].Length; j++)
                {
                    Assert.Equal(expected[i][j], returned[i][j]);
                }
            }
        }

        [Fact]
        public void Test2()
        {
            var points = new[]
            {
                new[]{3,3},
                new[]{5,-1},
                new[]{-2,4}
            };

            var expected = new[]
            {
                new[] { 3, 3 },
                new[]{ -2 ,4 }
            };

            var returned = Sort2dArray.KClosest(points, 2);
            for (var i = 0; i < returned.Length; i++)
            {
                for (var j = 0; j < returned[i].Length; j++)
                {
                    Assert.Equal(expected[i][j], returned[i][j]);
                }
            }
        }


        [Fact]
        public void Test3()
        {
            var points = new[]
            {
                new[]{1,0},
                new[]{0,1}
            };

            var expected = new[]
            {
                new[] { 1, 0 },
                new[]{ 0 ,1 }
            };

            var returned = Sort2dArray.KClosest(points, 2);
            for (var i = 0; i < returned.Length; i++)
            {
                for (var j = 0; j < returned[i].Length; j++)
                {
                    Assert.Equal(expected[i][j], returned[i][j]);
                }
            }
        }
    }
}