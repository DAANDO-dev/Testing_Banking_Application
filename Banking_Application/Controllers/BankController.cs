using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Banking_Application.Controllers
{
    public class BankController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Welcome to the Banking Application!");
        }

        [Route("/account-details")]
        public IActionResult AccountDetails()
            // Hard Coded data
        {
            var bankAccount = new
            {
                accountNumber = 1001,
                accountHolderName = "John Doe",
                currentBalance = 5000
            };
            //Send the object as JSON
            return Json(bankAccount);
        }

        [Route("/account-statement")]
        public IActionResult AccountStatement()
        {
            return File("/docs.pdf", "application/pdf");
        }

        [Route("/get-current-balance/{accountNumber:int?}")]
        public IActionResult GetCurrentBalance()
        {
            object accountNumberObj;

            if (HttpContext.Request.RouteValues.TryGetValue("accountNumber", out accountNumberObj) && 
                accountNumberObj is string accountNumber)
            {
                if (string.IsNullOrEmpty(accountNumber))
                {
                    return NotFound("Account number should be supplied.");
                }

                if (int.TryParse(accountNumber, out int accountNumberInt))
                {
                    // Hard-coded Data
                    var bankAccount = new
                    {
                        accountNumber = accountNumberInt,
                        accountHolderName = "John Doe",
                        currentBalance = 5000
                    };

                    if (accountNumberInt == 1001)
                    {
                        return Content(bankAccount.currentBalance.ToString());
                    }
                    else
                    {
                        return BadRequest("Invalid Account Number format");
                    }
                }
              
            }
            return NotFound("Account number should be supplied.");
        }
    }
}
