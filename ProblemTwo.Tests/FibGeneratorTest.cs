using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemTwo.Classes;

namespace ProblemTwo.Tests
{
    [TestClass]
    public class FibGeneratorTest
    {
        [TestMethod]
        public void GenerateFibReturned()
        {
            Assert.IsNotNull(FibGenerator.GenerateFib(20));
        }
    }
}