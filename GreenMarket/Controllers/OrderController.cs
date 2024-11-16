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
            return NotFound();
        }
        
        return user.Orders.Count == 0 ? View("NoOrders") : View(user);
    }
}