using System.Security.Claims;
using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class FarmerController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly IProductRepository _productRepository;

    public FarmerController(IUserRepository userRepository, IProductRepository productRepository)
    {
        _userRepository = userRepository;
        _productRepository = productRepository;
    }
    public ActionResult Index()
    {
        var user = GetCurrentUser();
        if (user == null || !RoleIsAppropriate(user.Role))
        {
            return View("BecomeFarmer");
        }

        return View(user);
    }

    public IActionResult BecomeFarmer()
    {
        if (!(bool)User.Identity?.IsAuthenticated)
        {
            TempData["message"] = "You have to log in to become a farmer";
            return RedirectToAction("Login", "Account");
        }

        var user = GetCurrentUser();
        if (user == null)
        {
            return Unauthorized();
        }

        user.Role = UserRole.Farmer;
        _userRepository.Update(user);
        
        return RedirectToAction("Index");
    }

    private UserEntity? GetCurrentUser()
    {
        var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
        if (userIdClaim == null)
            return null;
        
        var userId = Guid.Parse(userIdClaim.Value);
        var user = _userRepository.GetByIdWithCreatedProducts(userId);
        return user;
    }

    private bool RoleIsAppropriate(UserRole role)
    {
        return role is UserRole.Farmer or UserRole.Admin or UserRole.Moderator;
    }
}