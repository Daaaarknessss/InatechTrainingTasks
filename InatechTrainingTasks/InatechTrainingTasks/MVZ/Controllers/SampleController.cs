using KoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Reflection.Metadata;

namespace KoreMVC.Controllers
{
    public class SampleController : Controller
    {
        public string hello(String name, int no)
        {
            return "Happy Valentines Day dear" + name + "And you are the " + no + "th Visitor";
            
        }

        public IActionResult Index(String name, int no)
        {
            ViewData["name"] = name;
            ViewData["no"] = no;  
            return View();
        }
        public IActionResult GetCustomer()
        {
            Customer customer = new Customer() { CustomerId = 101, CustomerName = "Vignesh", Gender = "Male", Address = "Vellore", ContactNo = "9238983298" };
            return View("CustomerDisplay",customer);
        }
        public IActionResult NewCustomer()
        {
            return View();
        }
        public IActionResult SubmitCustomer(Customer customer) 
        {
            //return RedirectToAction("GetCustomer");
            return View("CustomerDisplay", customer);
        }
    }
}
