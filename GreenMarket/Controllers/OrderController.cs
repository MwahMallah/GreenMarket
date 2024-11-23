using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class OrderController : Controller
{
    private readonly IUserRepository _userRepository;

    public OrderController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public IActionResult Index()
    {
        var userId = this.GetCurrentUserId();
        var user = _userRepository.GetById(userId);

        if (user == null)
        {
            TempData["message"] = "You have to log in to see your orders";
            return RedirectToAction("Login", "Account");
        }
        
        return user.Orders.Count == 0 ? View("NoOrders") : View(user);
    }

    public IActionResult Harvests()
    {
        var userId = this.GetCurrentUserId();
        var user = _userRepository.GetById(userId);

        if (user == null)
        {
            TempData["message"] = "You have to log in to see your harvests";
            return RedirectToAction("Login", "Account");
        }
        
        return View(user);
    }
}