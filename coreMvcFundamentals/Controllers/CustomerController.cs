using coreMvcFundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcFundamentals.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> c1 = new List<Customer>()
        {
            new Customer(){ Id= 1,Name ="Waleed",Amount = 1400.12m },
            new Customer(){ Id= 2,Name ="Adnan",Amount = 1080.52m },
            new Customer(){ Id= 3,Name ="Nabeel",Amount = 1900.16m },
            new Customer(){ Id= 4,Name ="Huraib",Amount = 1400.10m },
            new Customer(){ Id= 5,Name ="Habiba",Amount = 1300.12m },
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System by ASP.NET Core";
            ViewBag.CustomerCount = c1.Count();
            ViewBag.CustomerList = c1;
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
