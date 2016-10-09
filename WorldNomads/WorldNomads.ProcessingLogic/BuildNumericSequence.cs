using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldNomads.ProcessingLogic
{
    public static class BuildNumericSequence
    {
        public static string NumericSequenceResponse(int inputValue)
        {
            string result = "";
            switch (inputValue >= 1)
            {
                case true:
                    result = Enumerable.Range(1, inputValue).Select(x => x.ToString())
                             .Aggregate((a, b) => a + ',' + b);
                    result = result.Contains(inputValue.ToString()) ? result : result + "," + inputValue.ToString();
                    break;
                case false:
                    result = "Invalid or No Input";
                    break;
            }
            return result;
        }
    }
}