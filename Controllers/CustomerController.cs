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
    }
}