using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
using WebAppML.Model;

namespace WebApp.Controllers
{
    public class PredictionController : Controller
    {
        [HttpGet]
        public IActionResult Predict()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Predict(ModelInput input)
        {
            var prediction = ConsumeModel.Predict(input);
            ViewBag.Result = prediction;

            return View();
        }
    }
}