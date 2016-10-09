using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldNomads.ProcessingLogic
{
    public static class BuildFibonacciSequence
    {
        public static string FibonnaciSequenceResponse(int inputValue)
        {
            string result = "0,";
            switch (inputValue < 1)
            {
                case false:
                    int ord1 = 1, ord2 = 1, ord3 = 0;
                    result = result +  Enumerable.Range(1, inputValue).Select(a =>
                    {
                        ord1 = ord2;
                        ord2 = ord3;
                        ord3 = ord1 + ord2;
                        return ord3;
                    }).Where(z =>  z <= inputValue && z >=0).Select(y => y.ToString()).Aggregate((a, b) => a + ',' + b);
                            result = result.Contains(inputValue.ToString()) ? result : result + "," + inputValue.ToString();
                 break;
                case true:
                    result = "Invalid or No Input";
                    break;
            }
            return result;
        }
    }
}

