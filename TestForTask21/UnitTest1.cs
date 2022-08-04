using Task21Project;
using Xunit;

namespace TestForTask21
{
    public class UnitTest1 
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(7, new Class().Sum(2, 5));
        }
    }
}