using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldNomads.Tests
{
    [TestClass]
    public class SpecialSequenceUnitTest
    {
        [TestMethod]
        public void VerifyZeroInputForSpecSequence()
        {
            int inputValue = 00000000000000000;
            string expectedResult = "Invalid or No Input";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue));
        }

        [TestMethod]
        //Test the First Positive Integer as Input
        public void VerifyPositiveInputForSpecSequence()
        {
            int inputValue = 00000000000000001;
            string expectedResult = "1";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue));

        }

        [TestMethod]
        //Input Value must show in Sequence
        public void VerifyInputInSpecSequence()
        {
            int inputValue = 56;
            bool isExpectedResult = true;
            Assert.IsNotNull(ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue));
            Assert.IsTrue(isExpectedResult, "56", ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue).Contains("56"));
        }

        [TestMethod]
        public void VerifyResultForSpecSequence()
        {
            int inputValue = 15;
            string expectedResult = "1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z";
            Assert.IsNotNull(ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue));
        }
    }

}

