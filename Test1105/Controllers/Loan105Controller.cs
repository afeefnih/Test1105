using Microsoft.AspNetCore.Mvc;
using Test1105.Models;

namespace Test1105.Controllers
{
    public class Loan105Controller : Controller
    {

        [HttpGet]
        public IActionResult LoanApplication105()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoanApplication105(Loan Monthly)
        {
            return View("LoanResult105",Monthly);
        }


    }
}
