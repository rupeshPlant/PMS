using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Account;
using Newtonsoft.Json;
using System.Security.Claims;
using UI.Services.Refit;

namespace UI.Controllers
{
    public class AccountController : BaseController
    {
        public readonly IAccountService _iAccountService;

        public AccountController(IAccountService iAccountService)
        {
            _iAccountService = iAccountService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromQuery] string? ReturnUrl, LoginModel model)
        {

            if (ModelState.IsValid)
            {
                var response = await _iAccountService.Login(model);
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    var personResult = JsonConvert.DeserializeObject<PersonModel>(result);
                    if (personResult.PersonId != null)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Email,model.UserName),
                            new Claim(ClaimTypes.NameIdentifier,personResult.PersonId),
                        };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)).Wait();

                        return !string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl) ? Redirect(ReturnUrl) : RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "Invalid Username or Password");
                        model.Password = "";
                        return View(model);
                    }
                }

                else
                {
                    ModelState.AddModelError("Password", "Invalid Username or Password");
                    model.Password = "";
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("Password", "Invalid Username or Password");
                model.Password = "";
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
