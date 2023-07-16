using Microsoft.AspNetCore.Mvc;

namespace WebAppFoundations20May.Areas.User.Controllers
{    
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
