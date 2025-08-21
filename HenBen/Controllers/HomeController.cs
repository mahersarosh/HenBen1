using System.Diagnostics;
using HenBen.Models;
using Microsoft.AspNetCore.Mvc;

namespace HenBen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Expenses()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEditExpense()
        {
            return View();
        }
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            return RedirectToAction("Index");
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
