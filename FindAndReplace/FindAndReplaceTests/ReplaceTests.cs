using FindAndReplace;
using Xunit;

namespace FindAndReplaceTests
{
    public class ReplaceTests
    {
        [Fact]
        public void Test1()
        {
            const string input = "abcd";
            var indices = new[] {0,2};
            var sources = new[] {"a","cd" };
            var targets = new[] {"eee", "ffff" };

            const string expected = "eeebffff";
            var returned = Replace.FindReplaceString(input, indices, sources, targets);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            const string input = "abcd";
            var indices = new[] { 0, 2 };
            var sources = new[] { "ab", "ec" };
            var targets = new[] { "eee", "ffff" };

            const string expected = "eeecd";
            var returned = Replace.FindReplaceString(input, indices, sources, targets);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            const string input = "jjievdtjfb";
            var indices = new[] {4, 6, 1 };
            var sources = new[] { "md", "tjgb", "jf" };
            var targets = new[] { "foe", "oov", "e"};

            const string expected = "jjievdtjfb";
            var returned = Replace.FindReplaceString(input, indices, sources, targets);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            const string input = "fvokzonyhukpwbnkomdianhirsvdulhsfseaqzktupyeverfsd";
            var indices = new[] { 26, 30, 38, 2, 41, 10, 8, 44, 19, 4, 13, 28, 21, 35, 23, 16 };
            var sources = new[] { "vd", "hsfs", "ktu", "ok", "pye", "kp", "hu", "verfs", "ia", "zon", "bnk", "ul", "nh", "aqz", "irs", "om" };
            var targets = new[] { "h", "gdlf", "nl", "sr", "xhn", "ax", "arf", "ifuax", "a", "mk", "vwqe", "fdl", "n", "miyr", "ibh", "den" };

            const string expected = "fvsrmkyarfaxwvwq" +
                                    "edendanibh" +
                                    "hfdlgdlfemiyrnlxhnifuaxd";
            var returned = Replace.FindReplaceString(input, indices, sources, targets);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test5()
        {
            const string input = "ejvzndtzn";

            var indices = new[] { 25, 35, 60, 77, 69, 79, 15, 19, 58, 92, 27, 64, 4, 11, 51, 7, 72, 67, 30, 0, 74, 98,
                                  17, 85, 48, 32, 38, 62, 43, 2, 9, 55, 87 };

            var sources = new[] { "gc", "tov", "vy", "re", "ikv", "lo", "dw", "iqgdbd", "ue", "kimbk", "tgu", "qd", "ndt", "elhe",
                                  "crq", "zn", "ec", "ff", "bz", "ej", "ua", "rh", "lw", "jj", "mfd", "cz", "ufn", "ex", "cjl", "vz",
                                  "cr", "agh", "znnj" };

            var targets = new[] { "dxs", "hn", "vfc", "wnr", "tira", "rko", "oob", "mlitiwj", "zrj", "onpp", "ot", "c", "lm", "hbsje", 
                                  "dgc", "ruf", "qi", "h", "vzn", "ja", "ow", "te", "km", "imq", "pia", "ixp", "xsod", "m", 
                                  "eat", "yf", "lzu", "dgy", "dyrsc" };

            const string expected = "jayflmruf";

            var returned = Replace.FindReplaceString(input, indices, sources, targets);
            Assert.Equal(expected, returned);
        }
    }
}
