using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemOne.Classes;
using System.Collections.Generic;

namespace ProblemOne.Tests
{
    [TestClass]
    public class NaturalNumbersTest
    {
        [TestMethod]
        public void GenerateNaturalNumbersReturned()
        {
            Assert.IsNotNull(NaturalNumbers.GenerateNaturalNumbers(20));
        }

        [TestMethod]
        public void GenerateNaturalNumbersValidated()
        {
            List<int> expected = new List<int> { 3, 6, 9, 12, 18, 0, 5, 10, 15 };
            
            CollectionAssert.AreEqual(expected, NaturalNumbers.GenerateNaturalNumbers(20));
        }

        [TestMethod]
        public void NaturalNumbersSumReturned()
        {
            Assert.IsNotNull(
                NaturalNumbers.NaturalNumbersSum(NaturalNumbers.GenerateNaturalNumbers(20))
            );
        }

        [TestMethod]
        public void NaturalNumbersSumValidated()
        {
            Assert.AreEqual(78,
                NaturalNumbers.NaturalNumbersSum(NaturalNumbers.GenerateNaturalNumbers(20))
            );
        }
    }
}
