using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Extensions;
using GreenMarket.Models.Farmer;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class FarmerController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly ICategoryRepository _categoryRepository;

    public FarmerController(IUserRepository userRepository, ICategoryRepository categoryRepository)
    {
        _userRepository = userRepository;
        _categoryRepository = categoryRepository;
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
    
    public IActionResult Create()
    {
        var mainCategories = _categoryRepository.GetMain();
        var createProductViewModel = new CreateProductViewModel
        {
            CategoryList = mainCategories
        };
        return View(createProductViewModel);
    }

    [HttpGet("Farmer/Category/{id:guid}")]
    public ActionResult<IEnumerable<CategoryEntity>> Category(Guid id)
    {
        var children = _categoryRepository.GetByParentId(id);
        return Ok(children);
    }
    
    [HttpPost]
    public ActionResult Create(CreateProductViewModel createUserViewModel)
    {
        if (ModelState.IsValid)
        {
            // _userRepository.Create(createUserViewModel.User);
            return RedirectToAction(nameof(Index));
        }
        return View(createUserViewModel);
    }

    private UserEntity? GetCurrentUser()
    {
        var userId = this.GetCurrentUserId();
        var user = _userRepository.GetByIdWithCreatedProducts(userId);
        return user;
    }

    private bool RoleIsAppropriate(UserRole role)
    {
        return role is UserRole.Farmer or UserRole.Admin or UserRole.Moderator;
    }
}