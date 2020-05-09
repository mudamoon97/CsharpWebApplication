using System;
using Microsoft.AspNetCore.Mvc;

namespace squarerootfinderweb.Controllers 
{
    public class SquRootController : Controller
    {
        [HttpGet]
        public ActionResult Sqrt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sqrt(string firstNumber, string secondNumber)
        {
            int Number1 = Convert.ToInt16(firstNumber);
            double SqrtNumber1 = Math.Sqrt(Number1);
            int Number2 = Convert.ToInt16(secondNumber);
            double SqrtNumber2 = Math.Sqrt(Number2);
            ViewBag.Result1 = SqrtNumber1;
            ViewBag.Result2 = SqrtNumber2;
            return View();
        }

    }
}