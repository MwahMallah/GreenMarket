using System.Diagnostics;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GreenMarket.Models;

namespace GreenMarket.Controllers;

public class ProductsController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;

    public ProductsController(ICategoryRepository categoryRepository, IProductRepository productRepository)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        var categories = _categoryRepository.GetMain();
        return View(nameof(Categories), categories);
    }

    public IActionResult Categories(Guid id)
    {
        if (_categoryRepository.GetById(id) == null)
        {
            return NotFound();
        }

        var categories = _categoryRepository.GetByParentId(id);

        if (!categories.Any())
        {
            return RedirectToAction(nameof(Products), new {categoryId=id});
        }

        return View(nameof(Categories), categories);
    }

    public IActionResult Products(Guid categoryId)
    {
        var products = _productRepository.GetByCategoryId(categoryId);
        return View(products);
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}