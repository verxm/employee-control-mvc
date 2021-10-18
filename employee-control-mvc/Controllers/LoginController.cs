using Microsoft.AspNetCore.Mvc;

namespace employee_control_mvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
