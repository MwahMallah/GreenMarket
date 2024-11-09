using System.Diagnostics;
using GreenMarket.DAL;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GreenMarket.Models;
using Microsoft.AspNetCore.Authorization;

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
        return View(categories);
    }

    public IActionResult Categories(Guid id)
    {
        var category = _categoryRepository.GetById(id);
        if (category == null)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Products), new {categoryId=id});
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