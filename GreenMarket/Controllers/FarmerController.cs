using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Extensions;
using GreenMarket.Models.Farmer;
using GreenMarket.Requests;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class FarmerController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;

    public FarmerController(IUserRepository userRepository, 
        ICategoryRepository categoryRepository,
        IProductRepository productRepository)
    {
        _userRepository = userRepository;
        _categoryRepository = categoryRepository;
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
    
    public IActionResult Create()
    {
        var mainCategories = _categoryRepository.GetMain();
        var createProductViewModel = new CreateProductViewModel
        {
            CategoryList = mainCategories
        };
        return View(createProductViewModel);
    }

    [HttpPost]
    public ActionResult Create([FromBody] ProductCreateRequest request)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState
                .Where(ms => ms.Value != null && ms.Value.Errors.Count > 0)
                .ToDictionary(
                    ms => ms.Key.Replace("$.", ""), 
                    ms => ms.Value?.Errors.Select(e => e.ErrorMessage).ToList()
                );

            return BadRequest(new
            {
                Message = "Validation failed",
                Errors = errors
            });
        }

        var newProduct = CreateProductEntityFrom(request);
        if (newProduct == null)
        {
            return Unauthorized();
        }
        _productRepository.Create(newProduct);
        TempData["message"] = "You created new product";
        return RedirectToAction("Index");
    }

    [HttpGet("Farmer/Category/{id:guid}")]
    public ActionResult<IEnumerable<CategoryEntity>> Category(Guid id)
    {
        var children = _categoryRepository.GetByParentId(id);
        return Ok(children);
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

    private ProductEntity? CreateProductEntityFrom(ProductCreateRequest request)
    {
        var creatorId = this.GetCurrentUserId();
        if (creatorId == null) {
            return null;
        }
        
        var newProduct = new ProductEntity
        {
            Name = request.Name,
            CategoryId = request.CategoryId,
            CreatorId = creatorId.Value,
            Description = request.Description,
            ImgUrl = request.ImgUrl
        };

        return newProduct;
    }
}