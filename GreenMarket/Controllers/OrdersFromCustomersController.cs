using GreenMarket.Common.Enums;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class OrdersFromCustomersController : Controller
{
    private readonly IOrderRepository _orderRepository;

    public OrdersFromCustomersController(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public IActionResult Index()
    {
        var userId = this.GetCurrentUserId();
        if (userId == null)
        {
            return Unauthorized();
        }
        
        var orders = _orderRepository.GetAllActiveByCreator(userId.Value);
        return View("Active", orders);
    }

    public IActionResult Delivered()
    {
        var userId = this.GetCurrentUserId();
        if (userId == null)
        {
            return Unauthorized();
        }
        
        var orders = _orderRepository.GetAllDeliveredByCreator(userId.Value);
        return View(orders);
    }

    public IActionResult Deliver(Guid id)
    {
        var order = _orderRepository.GetById(id);
        if (order == null)
        {
            return RedirectToAction("Index");
        }

        order.Status = OrderStatus.Delivered;
        _orderRepository.Update(order);
        TempData["message"] = $"You Delivered {order.Product.Name} to {order.User.Name}!";
        return RedirectToAction("Index");
    }
}