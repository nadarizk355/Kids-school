﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class indexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
