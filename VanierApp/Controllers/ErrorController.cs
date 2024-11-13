using Microsoft.AspNetCore.Mvc;

namespace VanierApp.Controllers
{
    //Error Controller class operations
    //New Changes
    public class ErrorController : Controller
    {

        public IActionResult Index()
        {
            ViewData["Title"] = "Error";
            return View();
        }
    }
}
