using Microsoft.AspNetCore.Mvc;

namespace backend_development_for_dotnet.Controllers
{
    public class Account: Controller
    {
        public IActionResult WeaklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password){
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }
    }
}