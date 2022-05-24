using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace UI.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var data = User.FindFirst(ClaimTypes.Email)?.Value;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
