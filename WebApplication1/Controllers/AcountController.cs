using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
