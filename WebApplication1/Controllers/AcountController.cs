using Microsoft.AspNetCore.Mvc;
using webapplication.BL.Models;

namespace WebApplication1.Controllers
{
    public class AcountController : Controller
    {



        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(RegistrationVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {


                }
                return View(model);

            }
            catch (Exception 
            ex)
            {
                return View(model);

            }
        }


        public IActionResult Login()
        {
            return View();
        }
      
        [HttpPost]
        public IActionResult  Login(LoginVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {


                }
                return View(model);

            }
            catch (Exception ex)
            {
                return View(model);

            }
        }
  /*
        public IActionResult Logout()
        {
            return View();
        }
        */


        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult   ForgetPassword(ForgetPasswordVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {


                }
                return View(model);

            }
            catch (Exception ex)
            {
                return View(model);

            }
        }


        public IActionResult confirmForgetPassword()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult confirmResetPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResetPassword (ResetPasswordVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {


                }
                return View(model);

            }
            catch (Exception ex)
            {
                return View(model);

            }
        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
