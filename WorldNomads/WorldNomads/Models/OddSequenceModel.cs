using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldNomads.ProcessingLogic;

namespace WorldNomads.Models
{
    public class OddSequenceModel
    {
        public string OddSequence { get; set; }

        public OddSequenceModel BuildResponseObject(int inputValue)
        {
            OddSequenceModel responseObject = new OddSequenceModel();
            responseObject.OddSequence = ProcessingLogic.BuildOddSequence.OddSequenceResponse(inputValue);
            return responseObject;
        }
    }
}