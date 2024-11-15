using GreenMarket.BL.Services.Interfaces;
using GreenMarket.Common.Constants;
using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using GreenMarket.Models.Account;
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
    public IActionResult Login(AccountLoginViewModel accountLoginViewModel)
    {
        if (!ModelState.IsValid)
            return View(accountLoginViewModel);

        var user = _userRepository.GetByUsername(accountLoginViewModel.Username);
        if (user != null && _userAuthenticator.Verify(user, accountLoginViewModel.Password))
        {
            AddTokenCookie(user);
            return RedirectToAction(nameof(Index), "Products");
        }
        
        ModelState.AddModelError("user", "Wrong Credentials");
        return View(accountLoginViewModel);
    }

    public ActionResult Logout()
    {
        Response.Cookies.Delete(Constants.AuthToken);
        return RedirectToAction("Login");
    }
    
    public ActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Register(AccountRegisterViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }
        
        var foundUserWithUsername = _userRepository.GetByUsername(viewModel.Username) != null;
        var foundUserWithEmail = _userRepository.GetByEmail(viewModel.Email) != null;
        if (foundUserWithUsername || foundUserWithEmail)
        {
            ModelState.AddModelError("user", "User with given username/email is already registered");
            return View(viewModel);
        }
        
        var registeredUser = _userRepository.Create(new UserEntity
        {
            Username = viewModel.Username,
            Password = viewModel.Password,
            Role = UserRole.User,
            Email = viewModel.Email
        });
        
        AddTokenCookie(registeredUser);
        return RedirectToAction(nameof(Index), "Products");
    }

    private void AddTokenCookie(UserEntity user)
    {
        var token = _jwtProvider.CreateToken(user);
        Response.Cookies.Append(Constants.AuthToken, token, new CookieOptions()
        {
            HttpOnly = true
        });
    }
}