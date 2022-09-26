using ValidMail;
using Xunit;

namespace ValidMailTests
{
    public class UniqueMailTests
    {
        [Fact]
        public void Test1()
        {
            var mails = new[]
            {
                "test.email+alex@leetcode.com", 
                "test.e.mail+bob.cathy@leetcode.com", 
                "testemail+david@lee.tcode.com"
            };

            var returned = UniqueMails.NumUniqueEmails(mails);
            Assert.Equal(2, returned);
        }


        [Fact]
        public void Test2()
        {
            var mails = new[]
            {
                "a@leetcode.com","b@leetcode.com","c@leetcode.com"
            };

            var returned = UniqueMails.NumUniqueEmails(mails);
            Assert.Equal(3, returned);
        }

        [Fact]
        public void Test3()
        {
            var mails = new[]
            {
                "test.email+alex@leetcode.com", "test.email.leet+alex@code.com"
            };

            var returned = UniqueMails.NumUniqueEmails(mails);
            Assert.Equal(2, returned);
        }
    }
}