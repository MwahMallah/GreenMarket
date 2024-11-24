using System.Diagnostics;
using System.Security.Claims;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Filters;
using Microsoft.AspNetCore.Mvc;
using GreenMarket.Models;
using GreenMarket.Models.Products;

namespace GreenMarket.Controllers;

public class ProductsController : Controller
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;
    private readonly IUserRepository _userRepository;

    public ProductsController(ICategoryRepository categoryRepository, 
        IProductRepository productRepository,
        IUserRepository userRepository)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
        _userRepository = userRepository;
    }

    public IActionResult Index()
    {
        var categories = _categoryRepository.GetMain();
        
        var categoryViewModel = new CategoryViewModel
        {
            Categories = categories,
            ParentList = []
        };
        return View(nameof(Categories), categoryViewModel);
    }

    public IActionResult Categories(Guid id)
    {
        if (_categoryRepository.GetById(id) == null)
        {
            return NotFound();
        }

        var categories = _categoryRepository.GetByParentId(id).ToList();

        if (!categories.Any())
        {
            return RedirectToAction(nameof(Products), new {categoryId=id});
        }

        var categoryViewModel = new CategoryViewModel
        {
            Categories = categories,
            ParentList = GetCategoryParents(id)
        };
        
        return View(nameof(Categories), categoryViewModel);
    }

    public IActionResult Products(Guid categoryId, ProductsFilter? filter)
    {
        var products = _productRepository.GetByCategoryId(categoryId);
        products = OrderProducts(products, filter);
        
        var productViewModel = new ProductViewModel()
        {
            Products = products, 
            ParentList = GetCategoryParents(categoryId)
        };
        
        return View(productViewModel);
    }
    
    public IActionResult Product(Guid id)
    {
        var product = _productRepository.GetById(id);

        if (product == null)
        {
            return NotFound();
        }
        
        return View(product);
    }

    public IActionResult Order(Guid id)
    {
        var product = _productRepository.GetById(id);

        if (product == null)
        {
            return NotFound();
        }
        
        if (!(bool)User.Identity?.IsAuthenticated)
        {
            TempData["message"] = "You have to log in to order product";
            return RedirectToAction("Login", "Account");
        }
        
        return View(product);
    }
    
    [HttpPost]
    [ActionName("Order")]
    public IActionResult OrderMake(Guid id, int amount)
    {
        var userId = Guid.Parse(
            User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty);
        var user = _userRepository.GetById(userId);
        var product = _productRepository.GetById(id);

        if (product == null || user == null)
        {
            return NotFound();
        }

        if (amount > product.Stock)
        {
            return BadRequest();
        }

        product.Stock -= amount;
        var uo = new OrderEntity
        {
            UserId = user.Id,
            ProductId = product.Id,
            Amount = amount
        };
        
        _productRepository.Update(product);
        user.Orders.Add(uo);
        _userRepository.Update(user);
        TempData["message"] = $"You ordered {product.Name}!";
        return View(product);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    private IEnumerable<CategoryEntity> GetCategoryParents(Guid id)
    {
        var parents = new List<CategoryEntity>();
        var parentCategory = _categoryRepository.GetById(id);
        while (parentCategory != null)
        {
            parents.Add(parentCategory);
            parentCategory = _categoryRepository.GetById(parentCategory.ParentId);
        }

        parents.Reverse();
        return parents;
    }

    private IEnumerable<ProductEntity> OrderProducts(IEnumerable<ProductEntity> products,
        ProductsFilter? filter)
    {
        return filter switch
        {
            ProductsFilter.Default => products,
            ProductsFilter.RatingDesc => products
                .OrderByDescending(p => p.Orders.Select(o => o.Rating).Average()),
            ProductsFilter.RatingAsc => products
                .OrderBy(p => p.Orders.Select(o => o.Rating).Average()),
            ProductsFilter.PriceDesc => products
                .OrderByDescending(p => p.Attributes
                    .Where(a => a.Attribute.Name.ToLower().StartsWith("price"))
                    .Select(a => Convert.ToDecimal(a.Value)) 
                    .FirstOrDefault()),
            ProductsFilter.PriceAsc => products
                .OrderBy(p => p.Attributes
                    .Where(a => a.Attribute.Name.ToLower().StartsWith("price"))
                    .Select(a => Convert.ToDecimal(a.Value)) 
                    .FirstOrDefault()),
            null => products,
            _ => products
        };
    }
}