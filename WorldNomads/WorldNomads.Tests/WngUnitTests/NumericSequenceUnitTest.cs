using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldNomads.Tests.WngUnitTests
{
    [TestClass]
    public class NumericSequenceUnitTest
    {
        [TestMethod]
        public void VerifyZeroInputForNumSequence()
        {
            int inputValue = 00000000000000000;
            string expectedResult = "Invalid or No Input";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue));
        }

        [TestMethod]
        //Test the First Positive Integer as Input
        public void VerifyPositiveInputForNumSequence()
        {
            int inputValue = 00000000000000001;
            string expectedResult = "1";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue));

        }

        [TestMethod]
        //Input Value must show in Sequence
        public void VerifyInputInNumSequence()
        {
            int inputValue = 56;
            bool isExpectedResult = true;
            Assert.IsNotNull(ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue));
            Assert.IsTrue(isExpectedResult, "56", ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue).Contains("56"));
        }

        [TestMethod]
        public void VerifyResultForNumSequence()
        {
            int inputValue = 12;
            string expectedResult = "1,2,3,4,5,6,7,8,9,10,11,12";
            Assert.IsNotNull(ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue));
        }
    }
}
