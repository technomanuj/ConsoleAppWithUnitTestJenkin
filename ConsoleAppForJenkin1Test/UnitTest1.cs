using System;
using Xunit;
using C_ConsoleAppForJenkin1;

namespace ConsoleAppForJenkin1Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result=FileCounter.CountFile();

             
            Assert.Equal(result, 2);
        }
    }
}
