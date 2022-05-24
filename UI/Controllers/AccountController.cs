using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Account;
using Models.Common;
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
        public IActionResult Login(string ReturnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewData["ReturnUrl"] = ReturnUrl;
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
                            new Claim(ClaimTypes.Name,personResult.Name),
                            new Claim(ClaimTypes.Email,personResult.Email),
                            new Claim(ClaimTypes.NameIdentifier,personResult.PersonId),
                            new Claim("UserName",personResult.UserName)
                        };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                        return !string.IsNullOrEmpty(ReturnUrl) ? Redirect(ReturnUrl) : RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Invalid", "Invalid Username or Password");
                        model.Password = "";
                        return View(model);
                    }
                }

                else
                {
                    ModelState.AddModelError("Invalid", "Invalid Username or Password");
                    model.Password = "";
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("Invalid", "Invalid Username or Password");
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


        public async Task<IActionResult> DisplayEmployee()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> EmployeeList()
        {
            var response = await _iAccountService.EmployeeList();
            var result = response.Content.ReadAsStringAsync().Result;
            var personResult = JsonConvert.DeserializeObject<EmployeeModel>(result);

            return Ok(personResult);
        }
        
    }
}
