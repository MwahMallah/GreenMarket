using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class AllFarmersController : Controller
{
    private readonly IUserRepository _userRepository;

    public AllFarmersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public IActionResult Index()
    {
        var users = _userRepository.GetAllFarmers();
        return View(users);
    }

    public IActionResult Farmer(Guid id)
    {
        var user = _userRepository.GetById(id);
        return View(user);
    }
}