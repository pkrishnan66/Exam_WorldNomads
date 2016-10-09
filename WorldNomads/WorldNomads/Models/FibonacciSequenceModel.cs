using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldNomads.ProcessingLogic;


namespace WorldNomads.Models
{
    public class FibonacciSequenceModel
    {
        public string FibonacciSequence { get; set; }

        public FibonacciSequenceModel BuildResponseObject(int inputValue)
        {
            FibonacciSequenceModel responseObject = new FibonacciSequenceModel();
            responseObject.FibonacciSequence = ProcessingLogic.BuildFibonacciSequence.FibonnaciSequenceResponse(inputValue);
            return responseObject;
        }
    }
}