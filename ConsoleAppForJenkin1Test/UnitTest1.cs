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
            int totalRecord=2;
             
            Assert.Equal(result, totalRecord);
        }

        
        [Fact]
        public void Test2()
        {
            var result=FileCounter.CountFile();
            int totalRecord=3;
             
            Assert.NotEqual(result, totalRecord);
        }
    }
}
