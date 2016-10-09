using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldNomads.ProcessingLogic
{
    public static class BuildOddSequence
    {
        public static string OddSequenceResponse(int inputValue)
        {
            string result = "";
            switch (inputValue < 1)
            {
                case true:
                    result = "Invalid or No Input";
                    break;
                case false:
                    result = Enumerable.Range(1, inputValue).Where(x => x % 2 != 0).Select(x => x.ToString())
                .Aggregate((a, b) => a + ',' + b);
                    result = result.Contains(inputValue.ToString()) ? result : result + "," + inputValue.ToString();
                    break;            
            }
            return result;
        }
    }
}