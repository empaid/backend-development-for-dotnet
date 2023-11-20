using backend_development_for_dotnet.Models;
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
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        public IActionResult LoginStrongPost(LoginViewModel login)
        {
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;
            ViewBag.Message = "Strongly Typed Form";
            return View();
        }
        public IActionResult UserDetail()
        {
            var user = new LoginViewModel() {Username="Hardik", Password="pass"};
            return View(user);
        }
        public IActionResult UserDetails()
        {
            var users = new List<LoginViewModel>(){
                new LoginViewModel(){Username="Hardik", Password="pass"},
                new LoginViewModel(){Username="Piyush", Password="pass"},
                new LoginViewModel(){Username="Disha", Password="pass"},

            };
            return View(users);
        }
    }
}