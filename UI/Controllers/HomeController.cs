using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
