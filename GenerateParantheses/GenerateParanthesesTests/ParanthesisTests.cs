using GenerateParantheses;
using System.Collections.Generic;
using Xunit;

namespace GenerateParanthesisTests
{
    public class ParanthesisTests
    {
        [Fact]
        public void N_1()
        {
            const int n = 1;
            var expected = new List<string>() {"()"};
            var returned = Paranthesis.GenerateParenthesis(n);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void N_2()
        {
            const int n = 2;
            var expected = new List<string>() { "(())", "()()" };
            var returned = Paranthesis.GenerateParenthesis(n);

            Assert.Equal(expected.Count, returned.Count);
            foreach (var element in expected)
            {
                Assert.True(returned.Contains(element));
            }
        }

        [Fact]
        public void N_3()
        {
            const int n = 3;
            var expected = new List<string>() { "((()))", "(())()", "()()()","(()())", "()(())" };
            var returned = Paranthesis.GenerateParenthesis(n);

            Assert.Equal(expected.Count, returned.Count);
            foreach (var element in expected)
            {
                Assert.True(returned.Contains(element));
            }
        }

        [Fact]
        public void N_4()
        {
            const int n = 4;
            var expected = new List<string>() { "(((())))", "((()()))", "((())())", "((()))()",
                                                "(()(()))", "(()()())", "(()())()", "(())(())", 
                                                "(())()()", "()((()))", "()(()())", "()(())()", 
                                                "()()(())", "()()()()" };

            var returned = Paranthesis.GenerateParenthesis(n);

            Assert.Equal(expected.Count, returned.Count);
            foreach (var element in expected)
            {
                Assert.True(returned.Contains(element));
            }
        }
    }
}
