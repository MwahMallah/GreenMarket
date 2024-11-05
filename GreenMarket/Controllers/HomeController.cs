using System.Diagnostics;
using GreenMarket.DAL;
using Microsoft.AspNetCore.Mvc;
using GreenMarket.Models;

namespace GreenMarket.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly GreenMarketDbContext _dbContext;
    
    public HomeController(ILogger<HomeController> logger, GreenMarketDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        var users = _dbContext.Users.ToList();
        return View(users);
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