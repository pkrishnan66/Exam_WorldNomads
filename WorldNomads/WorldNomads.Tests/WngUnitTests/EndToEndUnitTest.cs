using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldNomads.Tests.WngUnitTests
{
    [TestClass]
    public class EndToEndUnitTest
    {
        [TestMethod]
        public void VerifyZeroInput()
        {
            int inputValue = 00000000000000000;
            string expectedResult = "Invalid or No Input";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildFibonacciSequence.FibonnaciSequenceResponse(inputValue));
        }
    }
}
