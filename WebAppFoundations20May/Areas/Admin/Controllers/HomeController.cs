using Microsoft.AspNetCore.Mvc;

namespace WebAppFoundations20May.Areas.Admin.Controllers
{    
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
