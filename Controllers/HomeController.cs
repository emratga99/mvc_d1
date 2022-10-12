using System.Diagnostics; 
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Services;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using mvc_d2.Interface;
namespace mvc.Controllers;

public class HomeController : Controller
{
    private IMemberService _service;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IMemberService memberServices)
    {
        _logger = logger;
        _service = memberServices;
    }
    public IActionResult Index()
    {
        return View(_service.getViewList());
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
