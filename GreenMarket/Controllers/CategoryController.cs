using System.Text.Json;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Extensions;
using GreenMarket.Models.Category;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class CategoryController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(
        IUserRepository userRepository,
        ICategoryRepository categoryRepository)
    {
        _userRepository = userRepository;
        _categoryRepository = categoryRepository;
    }
    
    public IActionResult Index()
    {
        var userId = this.GetCurrentUserId();
        var user = _userRepository.GetById(userId);

        if (user == null)
        {
            TempData["message"] = "You have to log in to propose new category";
            return RedirectToAction("Login", "Account");
        }
        
        var createCategory = new CreateCategoryViewModel
        {
            Categories = _categoryRepository.GetAll()
        };
        return View(createCategory);
    }

    [HttpPost]
    public IActionResult Create(CreateCategoryViewModel createdCategory, [FromForm] string attributes)
    {
        if (!ModelState.IsValid)
        {
            createdCategory.Categories = _categoryRepository.GetAll();
            return View("Index", createdCategory);
        }
        
        List<CreateCategoryViewModel.AttributeViewModel>? attributesList;
        try
        {
            attributesList = JsonSerializer
                .Deserialize<List<CreateCategoryViewModel.AttributeViewModel>>(attributes);
        }
        catch (JsonException)
        {
            ModelState.AddModelError("Attributes", "Invalid attributes data.");
            createdCategory.Categories = _categoryRepository.GetAll();
            return View("Index", createdCategory);
        }
        
        var createdAttributes = CreateAttributeFrom(attributesList);
        
        _categoryRepository.Create(new CategoryEntity
        {
            Id = Guid.NewGuid(),
            Name = createdCategory.Name,
            ImgUrl = createdCategory.ImgUrl,
            ParentId = createdCategory.SelectedCategoryId,
            Attributes = createdAttributes,
        });
        
        return RedirectToAction("Index", "Products");
    }

    private ICollection<AttributeEntity> CreateAttributeFrom(
        IEnumerable<CreateCategoryViewModel.AttributeViewModel>? attributesList)
    {
        return attributesList?.Select(attr => new AttributeEntity
        {
            Id = Guid.NewGuid(),
            Name = attr.Name,
            CategoryId = attr.CategoryId,
        }).ToList() ?? [];
    }
}