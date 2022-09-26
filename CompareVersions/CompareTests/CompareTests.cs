using CompareVersions;
using Xunit;

namespace CompareTests
{
    public class CompareTests
    {
        [Fact]
        public void Test1()
        {
            const string version1 = "1.01";
            const string version2 = "1.001";

            var returned = Compare.CompareVersions(version1, version2);
            Assert.Equal(0, returned);
        }

        [Fact]
        public void Test2()
        {
            const string version1 = "1.0";
            const string version2 = "1.0.0";

            var returned = Compare.CompareVersions(version1, version2);
            Assert.Equal(0, returned);
        }

        [Fact]
        public void Test3()
        {
            const string version1 = "0.1";
            const string version2 = "1.0";

            var returned = Compare.CompareVersions(version1, version2);
            Assert.Equal(-1, returned);
        }

        [Fact]
        public void Test4()
        {
            const string version1 = "1.0.1";
            const string version2 = "1";

            var returned = Compare.CompareVersions(version1, version2);
            Assert.Equal(1, returned);
        }
        [Fact]
        public void Test5()
        {
            const string version1 = "7.5.2.4";
            const string version2 = "7.5.3";

            var returned = Compare.CompareVersions(version1, version2);
            Assert.Equal(-1, returned);
        }
    }
}
