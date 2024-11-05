using GreenMarket.BL.Services.Interfaces;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Controllers;

public class AccountController : Controller
{
    private readonly IUserRepository _userRepository;
    private readonly IUserAuthenticator _userAuthenticator;
    private readonly IJwtProvider _jwtProvider;

    public AccountController(
        IUserRepository userRepository,
        IUserAuthenticator userAuthenticator,
        IJwtProvider jwtProvider)
    {
        _userRepository = userRepository;
        _userAuthenticator = userAuthenticator;
        _jwtProvider = jwtProvider;
    }
    
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(AccountViewModel accountViewModel)
    {
        if (!ModelState.IsValid)
            return View(accountViewModel);

        var user = _userRepository.GetByUsername(accountViewModel.Username);
        if (user != null && _userAuthenticator.Verify(user, accountViewModel.Password))
        {
            AddTokenCookie(user);
            return RedirectToAction("Index", "Home");
        }
        
        ModelState.AddModelError("user", "Wrong Credentials");
        return View(accountViewModel);
    }

    private void AddTokenCookie(UserEntity user)
    {
        var token = _jwtProvider.CreateToken(user);
        Response.Cookies.Append("AuthToken", token, new CookieOptions()
        {
            HttpOnly = true
        });
    }
}