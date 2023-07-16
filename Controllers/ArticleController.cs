using Microsoft.AspNetCore.Mvc;

namespace WebAppFoundations20May.Controllers
{
    public class ArticleController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [NonAction] 
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
