using System.Security.Claims;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

[Authorize]
public class UserProfileController : Controller
{
    private readonly IUserRepository _userRepository;

    public UserProfileController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public ActionResult Index(Guid id)
    {
        if (!UserIsAuthorized(id)) {
            return Forbid();
        }

        var user = _userRepository.GetById(id);
        if (user == null) {
            return NotFound();
        }
        
        return View(user);
    }

    public ActionResult Edit(Guid id)
    {
        if (!UserIsAuthorized(id)) {
            return Forbid();
        }
        
        var user = _userRepository.GetById(id);
        if (user == null) {
            return NotFound();
        }

        return View(user);
    }

    [HttpPost]
    public ActionResult Edit(Guid id, UserEntity user)
    {
        if (!UserIsAuthorized(id)) {
            return Forbid();
        }

        if (!ModelState.IsValid) {
            return View(user);
        }

        _userRepository.Update(user);
        return RedirectToAction(nameof(Index), new {id=id});
    }

    private bool UserIsAuthorized(Guid id)
    {
        return User.FindFirstValue(ClaimTypes.NameIdentifier) == id.ToString();
    }
}