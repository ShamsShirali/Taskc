﻿using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
