using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorldNomads.Tests.WngUnitTests
{
    [TestClass]
    public class FibSequenceUnitTest
    {
        [TestMethod]
        public void VerifyZeroInputForFibSequence()
        {
            int inputValue = 00000000000000000;
            string expectedResult = "Invalid or No Input";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildFibonacciSequence.FibonnaciSequenceResponse(inputValue));
        }

        [TestMethod]
        //Test the First Positive Integer as Input
        public void VerifyPositiveInputForFebSequence()
        {
            int inputValue = 00000000000000001;
            string expectedResult = "0,1";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildFibonacciSequence.FibonnaciSequenceResponse(inputValue));

        }

        [TestMethod]
        //Test for second Positive Integer as Input
        public void VerifyNextInputForFebSequence()
        {
            int inputValue = 00000000000000002;
            string expectedResult = "0,1,1,2";
            Assert.AreEqual(expectedResult, ProcessingLogic.BuildFibonacciSequence.FibonnaciSequenceResponse(inputValue));

        }
    }
}
