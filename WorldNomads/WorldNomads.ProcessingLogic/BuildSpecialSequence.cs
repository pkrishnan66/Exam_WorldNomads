using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldNomads.ProcessingLogic
{
    public class BuildSpecialSequence
    {
        public static string SpecialSequenceResponse(int inputValue)
        {
            string result = "";
            switch (inputValue < 1)
            {
                case true:
                    result = "Invalid or No Input";
                    break;
                case false:
                    result = Enumerable.Range(1, inputValue).Select(x =>
                    {
                        if (x % 3 == 0 && x % 5 == 0)
                            return "Z";

                        if (x % 3 == 0)
                            return "C";

                        if (x % 5 == 0)
                            return "E";

                        return x.ToString();
                    }).Aggregate((a, b) => a + ',' + b);
                    break;
            }
            return result;
        }
    }
}