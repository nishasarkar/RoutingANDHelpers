using Microsoft.AspNetCore.Mvc;

namespace WebAppFoundations20May.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("Emp-details/{id}/{deptid}")]
        [Route("Employee/Index/{id}/{deptid}")]
        public IActionResult Index(int id, int deptid)
        {
            return View();
        }
    }
}
