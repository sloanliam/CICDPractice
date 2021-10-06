using System;
using Xunit;
using cicdpractice;

namespace testing
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            Calculator c = new Calculator();
            int expected = 4;
            Assert.Equal(c.Add(2, 2), expected);
        }

        [Fact]
        public void MulitplyTest(){
            Calculator c = new Calculator();
            int expected = 4;
            Assert.Equal(c.Multiply(2, 2), expected);
        }
    }
}
