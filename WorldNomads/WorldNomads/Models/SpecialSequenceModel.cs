using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldNomads.ProcessingLogic;

namespace WorldNomads.Models
{
    public class SpecialSequenceModel
    {
        public string SpecialSequence { get; set; }

        public SpecialSequenceModel BuildResponseObject(int inputValue)
        {
            SpecialSequenceModel responseObject = new SpecialSequenceModel();
            responseObject.SpecialSequence = ProcessingLogic.BuildSpecialSequence.SpecialSequenceResponse(inputValue);
            return responseObject;
        }
    }
}