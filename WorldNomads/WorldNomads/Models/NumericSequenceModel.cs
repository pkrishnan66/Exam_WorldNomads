using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldNomads.ProcessingLogic;


namespace WorldNomads.Models
{
    public class NumericSequenceModel
    {
        public string NumericSequence { get; set; }

        public NumericSequenceModel BuildResponseObject(int inputValue)
        {
            NumericSequenceModel responseObject = new NumericSequenceModel();
            responseObject.NumericSequence = ProcessingLogic.BuildNumericSequence.NumericSequenceResponse(inputValue);
            return responseObject;
        }
    }
}