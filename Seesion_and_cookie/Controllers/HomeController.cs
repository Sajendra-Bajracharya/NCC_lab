using Microsoft.AspNetCore.Mvc;

namespace Session_and_cookie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveName(string username)
        {
            HttpContext.Session.SetString("UserName", username);
            TempData["Message"] = "Login successful";

            return RedirectToAction("Welcome");
        }
        public IActionResult Welcome()
        {
            ViewBag.Name = HttpContext.Session.GetString("UserName");
            return View();
        }
    }
}
