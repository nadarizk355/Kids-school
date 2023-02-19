using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AcountController : Controller
    {



        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
