﻿using Microsoft.AspNetCore.Mvc;

namespace VanierApp.Controllers
{
    //Error Controller class operations
    //New Changes
    //This one is for Command Line now
    //demo branch 2
    public class ErrorController : Controller
    {

        public IActionResult Index()
        {
            ViewData["Title"] = "Error";
            return View();
        }
    }
}
