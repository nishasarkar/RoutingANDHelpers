using Microsoft.AspNetCore.Mvc;

namespace WebAppFoundations20May.Controllers
{
    public class ProductController : Controller
    {
        //model binding mechanisim
        public IActionResult Index(int id, int catid)
        {
            return View();
        }
    }
}
