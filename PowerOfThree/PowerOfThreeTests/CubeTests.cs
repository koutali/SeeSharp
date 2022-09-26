using System;
using PowerOfThree;
using Xunit;

namespace PowerOfThreeTests
{
    public class CubeTests
    {
        [Fact]
        public void FortyFive()
        {
            Assert.False(Cube.IsPowerOfThree(45));
        }

        [Fact]
        public void Nine()
        {
            Assert.True(Cube.IsPowerOfThree(9));
        }

        [Fact]
        public void TwoHundredFortyThree()
        {
            Assert.True(Cube.IsPowerOfThree(243));
        }

        [Fact]
        public void Eight()
        {
            Assert.False(Cube.IsPowerOfThree(8));
        }

        [Fact]
        public void MinusOne()
        {
            Assert.False(Cube.IsPowerOfThree(-1));
        }
    }
}
