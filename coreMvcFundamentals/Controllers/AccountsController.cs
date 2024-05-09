using coreMvcFundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcFundamentals.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        } 
        
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        [HttpPost]

        public IActionResult LoginSuccess(LoginViewModel loginModel)
        {
            ViewBag.Username = loginModel.Username;
            ViewBag.Password = loginModel.Password;

            return View();
        }
        [HttpPost]
        public IActionResult loginPost(string username,string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }
    }
}
