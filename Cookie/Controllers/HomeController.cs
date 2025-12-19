using Microsoft.AspNetCore.Mvc;

namespace CookieQueryDemo.Controllers
{
    public class HomeController : Controller
    {
        // Page 1
        public IActionResult Index()
        {
            // Read cookie if exists
            ViewBag.Theme = Request.Cookies["Theme"];
            return View();
        }

        // Save theme in Cookie
        [HttpPost]
        public IActionResult SetTheme(string theme)
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7)
            };

            Response.Cookies.Append("Theme", theme, options);

            return RedirectToAction("Index");
        }

        // Page 2 (Query String)
        public IActionResult Product(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
    }
}
