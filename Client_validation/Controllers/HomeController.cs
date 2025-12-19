using Client_validation.Models;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegistration model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save the user to the database
                ViewBag.Message = "Registration successful!";
                return View("Index", new UserRegistration());
            }

            return View("Index", model);
        }
    }
}
