using Calculator.Models;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calculate(CalculatorModel model)
        {
            ModelState.Clear();
            if (model.Operation != null && model.Operation != "")
            {
                try
                {
                    switch (model.Operation)
                    {
                        case "+":
                            model.Result = model.Number1 + model.Number2;
                            break;
                        case "-":
                            model.Result = model.Number1 - model.Number2;
                            break;
                        case "*":
                            model.Result = model.Number1 * model.Number2;
                            break;
                        case "/":
                            if (model.Number2 == 0)
                            {
                                model.ErrorMessage = "Cannot divide by zero!";
                            }
                            else
                            {
                                model.Result = model.Number1 / model.Number2;
                            }
                            break;
                        default:
                            model.ErrorMessage = "Invalid operation selected.";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    model.ErrorMessage = $"An error occurred: {ex.Message}";
                }
            }
            else
            {
                model.ErrorMessage = "Please select an operation.";
            }
            return View("Index", model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}