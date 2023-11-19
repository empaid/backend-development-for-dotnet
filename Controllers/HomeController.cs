using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using backend_development_for_dotnet.Models;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace backend_development_for_dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ActionSample()
    {
        return View();
    }
    
    public ViewResult Message()
    {
        return View();
    }
    public string Str()
    {
        return "Returned as string";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
