using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDashboard()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Games()
        {
            return View();
        }


        public IActionResult Certificate()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}

