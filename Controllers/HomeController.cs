using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppFoundations20May.Models;

namespace WebAppFoundations20May.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //return View("~/views/article/index.cshtml");
            // return View("Privacy");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //convention based routing can serve n-numbers of route u dont need to define pattern or route for each controller.
        //Areas is in different section of the project or admin module that cant not be accessible without login.
        //it is helping in code management 
        //Area is deviding the project module wise
        //when we are sending the value in server side we are using" Name" attribute instead of ID is helpful dom manupulation using javascript
        //or J-query
        //iformaction-key value pair
        //for taking input from user we can use strongly typed value,
        //asp-antiforgerytoken=token,create hidden field and prevent spamming
        //iform collection -how many text box are there then go ahead with the iform collection this is the built in collection for receiving the values
        //iform collection is ment for post methods.
        //
    }
}