using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GreenMarket.Controllers;

[Authorize(Roles = "Moderator")]
public class ModeratorController : Controller
{
    private readonly ICategoryRepository _categoryRepository;

    public ModeratorController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
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

        return View(category);
    }
    
    [HttpPost]
    public IActionResult Edit(CategoryEntity category)
    {
        if (category.Name.IsNullOrEmpty())
        {
            ModelState.AddModelError("Name", "Name is required");
            return View(category);
        }
        
        _categoryRepository.Update(category);
        TempData["message"] = $"You edited {category.Name}";
        return RedirectToAction(nameof(Added));
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