using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using WorldNomads.Models;

namespace WorldNomads.Controllers
{
    public class NumericSequenceController : Controller
    {
        //
        // GET: /NumericSequence/

        public ActionResult NumericSequence()
        {
            return View();
        }

        [HttpGet]
        public string EvenSequenceResult(int inputValue)
        {
            EvenSequenceModel model = new EvenSequenceModel();
            model = model.BuildResponseObject(inputValue);
            return model.EvenSequence ;
         }

        [HttpGet]
        public string OddSequenceResult(int inputValue)
        {

            OddSequenceModel model = new OddSequenceModel();
            model = model.BuildResponseObject(inputValue);
            return model.OddSequence;
        }

        [HttpGet]
        public string NumericSequenceResult(int inputValue)
        {
            NumericSequenceModel model = new NumericSequenceModel();
            model = model.BuildResponseObject(inputValue);
            return model.NumericSequence;
        }

        [HttpGet]
        public string SpecialSequenceResult(int inputValue)
        {
            SpecialSequenceModel model = new SpecialSequenceModel();
            model = model.BuildResponseObject(inputValue);
            return model.SpecialSequence;
        }

        [HttpGet]
        public string FibonacciSequenceResult(int inputValue)
        {
            FibonacciSequenceModel model = new FibonacciSequenceModel();
            model = model.BuildResponseObject(inputValue);
            return model.FibonacciSequence;
        }
    }
}
