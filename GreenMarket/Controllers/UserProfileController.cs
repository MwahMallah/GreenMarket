using System.Security.Claims;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

[Authorize]
public class UserProfileController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly IUserOrderRepository _userOrderRepository;

    public UserProfileController(IUserRepository userRepository, IUserOrderRepository userOrderRepository)
    {
        _userRepository = userRepository;
        _userOrderRepository = userOrderRepository;
    }
    public ActionResult Index(Guid id)
    {
        if (!UserIsAuthorized(id)) {
            return Forbid();
        }

        var user = _userRepository.GetById(id);
        if (user == null) {
            return NotFound();
        }
        
        return View(user);
    }

    public ActionResult Edit(Guid id)
    {
        if (!UserIsAuthorized(id)) {
            return Forbid();
        }
        
        var user = _userRepository.GetById(id);
        if (user == null) {
            return NotFound();
        }

        return View(user);
    }

    [HttpPost]
    public ActionResult Edit(Guid id, UserEntity user)
    {
        if (!UserIsAuthorized(id)) {
            return Forbid();
        }

        if (!ModelState.IsValid) {
            return View(user);
        }

        _userRepository.Update(user);
        return RedirectToAction(nameof(Index), new {id=id});
    }

    [HttpPost]
    public ActionResult RateProduct([FromBody] OrderRatingRequest request)
    {
        var order = _userOrderRepository.GetById(request.OrderId);
        if (order == null)
        {
            return NotFound();
        }
        
        if (order.UserId.ToString() != User.FindFirstValue(ClaimTypes.NameIdentifier))
        {
            return Unauthorized();
        }

        order.Rating = request.Rating;
        _userOrderRepository.Update(order);
        
        return Ok($"Thank you for your review!");
    }

    private bool UserIsAuthorized(Guid id)
    {
        return User.FindFirstValue(ClaimTypes.NameIdentifier) == id.ToString();
    }
}