using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldNomads.Tests
{
    [TestClass]
    public class OddSequenceUnitTest
    {
        [TestMethod]
        public void VerifyZeroInputForOddSequence()
        {
            int inputValue = 00000000000000000;
            string expectedResult = "Invalid or No Input";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue));
        }

        [TestMethod]
        //Test the First Positive Integer as Input
        public void VerifyPositiveInputForOddSequence()
        {
            int inputValue = 00000000000000001;
            string expectedResult = "1";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue));

        }

        [TestMethod]
        //Input Value must show in Sequence
        public void VerifyInputInOddSequence()
        {
            int inputValue = 56;
            bool isExpectedResult = true;
            Assert.IsNotNull(ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue));
            Assert.IsTrue(isExpectedResult, "56", ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue).Contains("56"));
        }

        [TestMethod]
        public void VerifyResultForEvenSequence()
        {
            int inputValue = 12;
            string expectedResult = "1,3,5,7,9,11,12";
            Assert.IsNotNull(ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue));
        }
    }
}
