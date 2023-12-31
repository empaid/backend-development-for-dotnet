using backend_development_for_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend_development_for_dotnet.Controllers
{
    public class CustomerController: Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer(){ Id=101, Name="Hardik", Amount=2300},
            new Customer(){ Id=102, Name="Disha", Amount=5000},
            new Customer(){ Id=103, Name="Piyush", Amount=7800}
        };
        public IActionResult Index()
        {
            ViewBag.Message = "View Bag Message";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }
        public IActionResult Details()
        {
            ViewData["Message"] = "View Data Message";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"] = customers;
            return View();
        }
        public IActionResult TempDataMethod()
        {
            TempData["Message"] = "Temp Data Message";
            TempData["CustomerCount"] = customers.Count();
            TempData["CustomerList"] = customers;
            return View();
        }
        public IActionResult Method2()
        {
            if(TempData["Message"]==null)
                return RedirectToAction("Index");
            ViewBag.Message = TempData["Message"].ToString();
            return View();
        }
        [Route("~/")]
        [Route("/sample/message")]
        public string Message()
        {
            return "Message String";
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "hardik");
            return RedirectToAction("Success");
        }
        public IActionResult Success()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }

        public IActionResult QueryTest()
        {
            string name = "Hardik Purohit";
            if(!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];
            ViewBag.Name = name;
            return View();
        }
    }
}