using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomads.ProcessingLogic;


namespace WorldNomads.Tests
{
    [TestClass]
    public class EvenSequenceUnitTest
    {
        [TestMethod]
        public void VerifyZeroInputForEvenSequence()
        {
            int inputValue = 00000000000000000;
            string expectedResult = "Invalid or No Input";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue));
        }

        [TestMethod]
        //Verify First Positive Integer as Input
        public void VerifyPositiveInputForEvenSequence()
        {
            int inputValue = 00000000000000001;
            string expectedResult = "Invalid or No Input";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue));

        }

        [TestMethod]
        //Verify if Input is in Even Sequence
        public void VerifyInputInEvenSequence()
        {
            int inputValue = 57;
            bool isExpectedResult = true;
            Assert.IsNotNull(ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue));
            Assert.IsTrue(isExpectedResult, "57",ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue).Contains("57"));
          }

        [TestMethod]
        public void VerifyResultForEvenSequence()
        {
            int inputValue = 13;
            string expectedResult = "2,4,6,8,10,12,13";
            Assert.IsNotNull(ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue));
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue));
        }


    }
}
