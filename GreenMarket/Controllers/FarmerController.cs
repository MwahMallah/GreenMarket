using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Extensions;
using GreenMarket.Models.Farmer;
using GreenMarket.Requests;
using GreenMarket.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GreenMarket.Controllers;

public class FarmerController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;
    private readonly IProductAttributeRepository _productAttributeRepository;
    private readonly IHarvestRepository _harvestRepository;

    public FarmerController(IUserRepository userRepository, 
        ICategoryRepository categoryRepository,
        IProductRepository productRepository,
        IProductAttributeRepository productAttributeRepository,
        IHarvestRepository harvestRepository)
    {
        _userRepository = userRepository;
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
        _productAttributeRepository = productAttributeRepository;
        _harvestRepository = harvestRepository;
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

        CreateAttributeEntitiesFrom(request.Attributes, newProduct);
        
        TempData["message"] = "You created new product";
        return RedirectToAction("Index");
    }

    public IActionResult CreateHarvest()
    {
        var user = GetCurrentUser();
        if (user == null || !RoleIsAppropriate(user.Role))
        {
            return View("BecomeFarmer");
        }

        var createHarvestViewModel = new CreateHarvestViewModel()
        {
            Products = user.CreatedProducts
                .Where(p => p.Type == ProductSalesType.Harvest)
        };
        
        return View(createHarvestViewModel);
    }
    
    [HttpPost]
    public IActionResult CreateHarvest(CreateHarvestViewModel viewModel)
    {
        var user = GetCurrentUser();
        if (user == null || !RoleIsAppropriate(user.Role))
        {
            return View("BecomeFarmer");
        }

        if (viewModel.Harvest.ProductId == Guid.Empty)
        {
            TempData["message"] = "Please select a product for the harvest.";
            viewModel.Products = user.CreatedProducts
                .Where(p => p.Type == ProductSalesType.Harvest);
            return View(viewModel);
        }

        if (viewModel.Harvest.StartTime > viewModel.Harvest.EndTime)
        {
            TempData["message"] = "The end time must be later than the start time.";
            viewModel.Products = user.CreatedProducts
                .Where(p => p.Type == ProductSalesType.Harvest);
            return View(viewModel);
        }
        
        var newHarvest = viewModel.Harvest;
        _harvestRepository.Create(newHarvest);
        
        TempData["message"] = "You created harvest.";
        return RedirectToAction("Index");
    }
    
    [HttpGet("Farmer/Category/{id:guid}")]
    public ActionResult<IEnumerable<CategoryResponse<object>>> Category(Guid id)
    {
        var children = _categoryRepository.GetByParentId(id).ToList();
        if (children.Count != 0)
        {
            var responseCategories = new CategoryResponse<CategoryEntity>
            {
                Type = "categories",
                Payload = children
            };
            return Ok(responseCategories);
        }

        var category = _categoryRepository.GetById(id);
        if (category == null)
        {
            return NotFound();
        }

        var responseAttributes = new CategoryResponse<AttributeEntity>()
        {
            Type = "attributes",
            Payload = category.Attributes
        };
        return Ok(responseAttributes);
    }

    public IActionResult Edit(Guid id)
    {
        var product = _productRepository.GetById(id);
        if (product == null)
        {
            return NotFound();
        }
        
        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(ProductEntity product)
    {
        if (product.Name.IsNullOrEmpty())
        {
            ModelState.AddModelError("Name", "Name is required");
            return View(product);
        }

        if ((ModelState.ContainsKey("Stock") && ModelState["Stock"]!.Errors.Any()) 
            || product.Stock < 0)
        {
            ModelState.AddModelError("Stock", "Invalid input for stock");
            return View(product);
        }   
        
        _productRepository.Update(product);
        TempData["message"] = $"You edited {product.Name}";
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(Guid id)
    {
        var product = _productRepository.GetById(id);
        return View(product);
    }

    [HttpPost]
    [ActionName("Delete")]
    public ActionResult DeleteInDb(Guid id)
    {
        var productFromDb = _productRepository.GetById(id);
        if (productFromDb == null)
        {
            return NotFound();
        }
        
        _productRepository.Delete(productFromDb);
        return RedirectToAction(nameof(Index));
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
            Type = request.Type,
            ImgUrl = request.ImgUrl
        };

        return newProduct;
    }
    
    private void CreateAttributeEntitiesFrom(
        IEnumerable<ProductCreateRequest.AttributeRequest> requestAttributes, 
        ProductEntity product)
    {
        foreach (var attr in requestAttributes)
        {
            var attrEntity = new ProductAttributeEntity
            {
                Id = Guid.NewGuid(),
                Value = attr.Value,
                ProductId = product.Id,
                AttributeId = attr.Id,
            };
            _productAttributeRepository.Create(attrEntity);
        }
    }
}