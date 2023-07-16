using Microsoft.AspNetCore.Mvc;
using WebAppFoundations20May.Models;

namespace WebAppFoundations20May.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login(string Username, string Password)
        //{
        //    if(Username!=null && Password!=null)
        //    {
        //        // TO DO:
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Login(LoginModel model)
        //{
        //    if (model.Username != null && model.Password != null)
        //    {
        //        // TO DO:
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View();
        //}

        //[ValidateAntiForgeryToken]
        //[HttpPost]
        //public IActionResult Login(LoginModel model)
        //{
        //    if (model.Username != null && model.Password != null)
        //    {
        //        // TO DO:
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View();
        //}

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            string Username = form["username"];
            string Password = form["password"];

            if (Username != null && Password != null)
            {
                // TO DO:
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
