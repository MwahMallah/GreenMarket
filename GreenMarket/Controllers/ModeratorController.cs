using System.Text.Json;
using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Models.Moderator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GreenMarket.Controllers;

[Authorize(Roles = "Moderator")]
public class ModeratorController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IAttributeRepository _attributeRepository;

    public ModeratorController(
        ICategoryRepository categoryRepository,
        IAttributeRepository attributeRepository)
    {
        _categoryRepository = categoryRepository;
        _attributeRepository = attributeRepository;
    }
    
    public IActionResult Index()
    {
        var proposedCategories = _categoryRepository.GetAllPending();
        return View(proposedCategories);
    }

    public IActionResult Accept(Guid id)
    {
        var proposedCategory = _categoryRepository.GetById(id);
        if (proposedCategory == null)
        {
            return NotFound();
        }

        proposedCategory.Status = CategoryStatus.Accepted;
        _categoryRepository.Update(proposedCategory);
        
        TempData["message"] = $"You accepted category {proposedCategory.Name}";
        return RedirectToAction("Index");
    }

    public IActionResult Added()
    {
        var categories = _categoryRepository.GetAll();
        return View(categories);
    }

    public IActionResult Edit(Guid id)
    {
        var category = _categoryRepository.GetById(id);

        if (category == null)
        {
            return NotFound();
        }
        
        var categoryViewModel = new EditCategoryViewModel
        {
            Category = category,
            Attributes = category.Attributes.Select(a 
                => new EditCategoryViewModel.AttributeViewModel
                {
                    Id = a.Id,
                    CategoryId = a.CategoryId,
                    Name = a.Name,
                    IsRequired = a.IsRequired
                })
        };
        return View(categoryViewModel);
    }
    
    [HttpPost]
    public IActionResult Edit(EditCategoryViewModel categoryViewModel, [FromForm] string attributes)
    {
        if (categoryViewModel.Category.Name.IsNullOrEmpty())
        {
            ModelState.AddModelError("Name", "Name is required");
            return View(categoryViewModel);
        }

        List<EditCategoryViewModel.AttributeViewModel>? attributeList;
        try
        {
            attributeList = JsonSerializer
                .Deserialize<List<EditCategoryViewModel.AttributeViewModel>>(attributes);
        }
        catch(JsonException)
        {
            return BadRequest();
        }
        
        UpdateCategoryAttributes(attributeList);
        
        _categoryRepository.Update(categoryViewModel.Category);
        TempData["message"] = $"You edited {categoryViewModel.Category.Name}";
        return RedirectToAction(nameof(Added));
    }
    
    private void UpdateCategoryAttributes(
        List<EditCategoryViewModel.AttributeViewModel>? attributeList)
    {
        if (attributeList == null)
        {
            return;
        }
        
        foreach (var attribute in attributeList)
        {
            if (attribute.Id == null)
            {
                _attributeRepository.Create(new AttributeEntity
                {
                    Id = Guid.NewGuid(),
                    CategoryId = attribute.CategoryId,
                    Name = attribute.Name,
                    IsRequired = attribute.IsRequired
                });
            }
            else
            {
                _attributeRepository.Update(new AttributeEntity
                {
                    Id = attribute.Id.Value,
                    Name = attribute.Name,
                    CategoryId = attribute.CategoryId,
                    IsRequired = attribute.IsRequired
                });
            }
        }
    }

    public IActionResult Delete(Guid id)
    {
        var category = _categoryRepository.GetById(id);
        return View(category);
    }
    
    [HttpPost]
    [ActionName("Delete")]
    public ActionResult DeleteInDb(Guid id)
    {
        var categoryFromDb = _categoryRepository.GetById(id);
        if (categoryFromDb == null)
        {
            return NotFound();
        }
        
        _categoryRepository.Delete(categoryFromDb);
        return RedirectToAction(nameof(Index));
    }
}