using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldNomads.ProcessingLogic;


namespace WorldNomads.Models
{
    public class EvenSequenceModel
    {
        public string EvenSequence { get; set; }
        
        /// <summary>
        /// Buils the Sequence Response Object...
        /// </summary>
        /// <param name="inputValue">input Value</param>
        /// <returns>NumericSequenceModel</returns>
        public EvenSequenceModel BuildResponseObject(int inputValue)
        {
           EvenSequenceModel responseObject = new EvenSequenceModel();
           responseObject.EvenSequence = ProcessingLogic.BuildEvenSequence.EvenSequenceResponse(inputValue);
           return responseObject;
        }
    }
}