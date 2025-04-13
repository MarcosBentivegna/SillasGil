using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SillasGil.Models;

namespace SillasGil.Controllers;

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

    public IActionResult Gestion_inventario()
    {
        return View();
    }

    public IActionResult Forgotpassword()
    {
        return View();
    }

    public IActionResult Cards()
    {
        return View();
    }

    public IActionResult Blank()
    {
        return View();
    }

    public IActionResult Utilitiesanimation()
    {
        return View();
    }

    public IActionResult Utilitiescolor()
    {
        return View();
    }

    public IActionResult Utilitiesborder()
    {
        return View();
    }

    public IActionResult Utilitiesother()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Error404()
    {
        return View();
    }

    public IActionResult Buttons()
    {
        return View();
    }

    public IActionResult Tables()
    {
        return View();
    }

    public IActionResult Charts()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
