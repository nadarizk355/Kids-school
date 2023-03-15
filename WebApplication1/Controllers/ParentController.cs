using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ParentController : Controller
    {
        public IActionResult ParentDashboard()
        {
            return View();
        }

        public IActionResult Kids()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult ProfileParent()
        {
            return View();
        }
    }
}
