using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class HarvestController : Controller
{
    private readonly IHarvestRepository _harvestRepository;
    private readonly IUserRepository _userRepository;

    public HarvestController(IHarvestRepository harvestRepository,
        IUserRepository userRepository)
    {
        _harvestRepository = harvestRepository;
        _userRepository = userRepository;
    }
    
    public IActionResult Register(Guid id)
    {
        var harvest = _harvestRepository.GetById(id);
        if (harvest == null)
        {
            return NotFound();
        }

        if (harvest.EndTime < DateTime.Now)
        {
            return BadRequest();
        }
        
        if (!(bool)User.Identity?.IsAuthenticated)
        {
            TempData["message"] = "You have to log in to register for harvest";
            return RedirectToAction("Login", "Account");
        }

        var currentUserId = this.GetCurrentUserId();
        //users can't register twice for the same event
        if (harvest.Participants.Any(p => p.Id == currentUserId))
        {
            return BadRequest();
        }

        var currentUser = _userRepository.GetById(currentUserId);
        if (currentUser == null)
        {
            return NotFound();
        }
        
        harvest.Participants.Add(currentUser);
        _harvestRepository.Update(harvest);

        TempData["message"] = "You registered to harvest";
        return RedirectToAction("Product", 
            "Products", new {id = harvest.ProductId});
    }
    
}