using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Models.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly IUserRepository _userRepository;

    public AdminController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public ActionResult Index()
    {
        var users = _userRepository.GetAll();
        return View(users);
    }

    public ActionResult Create()
    {
        return View(new CreateUserViewModel());
    }

    [HttpPost]
    public ActionResult Create(CreateUserViewModel createUserViewModel)
    {
        if (ModelState.IsValid)
        {
            _userRepository.Create(createUserViewModel.User);
            return RedirectToAction(nameof(Index));
        }
        return View(createUserViewModel);
    }

    public ActionResult Edit(Guid id)
    {
        var user = _userRepository.GetById(id);
        return user == null ? NotFound() : View(user);
    }
    
    [HttpPost]
    public ActionResult Edit(UserEntity user)
    {
        if (ModelState.IsValid)
        {
            _userRepository.Update(user);
            return RedirectToAction(nameof(Index));
        }
        return View(user);
    }

    public ActionResult Delete(Guid id)
    {
        var user = _userRepository.GetById(id);
        return user == null ? NotFound() : View(user);
    }

    [HttpPost]
    [ActionName("Delete")]
    public ActionResult DeleteInDb(Guid id)
    {
        var userFromDb = _userRepository.GetById(id);
        if (userFromDb == null)
        {
            return NotFound();
        }
        
        _userRepository.Delete(userFromDb);
        return RedirectToAction(nameof(Index));
    }
}