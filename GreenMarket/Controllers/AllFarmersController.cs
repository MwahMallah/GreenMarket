using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Filters;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class AllFarmersController : Controller
{
    private readonly IUserRepository _userRepository;

    public AllFarmersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public IActionResult Index(FarmersFilter? filter)
    {
        var farmers = _userRepository.GetAllFarmers();
        farmers = FilterFarmers(farmers, filter);
        return View(farmers);
    }

    public IActionResult Farmer(Guid id)
    {
        var farmer = _userRepository.GetById(id);
        return View(farmer);
    }
    
    private IEnumerable<UserEntity> FilterFarmers(IEnumerable<UserEntity> farmers, 
        FarmersFilter? filter)
    {
        return filter switch
        {
            FarmersFilter.Default => farmers,
            FarmersFilter.RatingDesc => farmers
                .OrderByDescending(f => f.CreatedProducts
                    .SelectMany(p => p.Orders).Average(o => o.Rating)),
            FarmersFilter.RatingAsc => farmers
                .OrderBy(f => f.CreatedProducts
                    .SelectMany(p => p.Orders).Average(o => o.Rating)),
            null => farmers,
            _ => farmers
        };
    }
}