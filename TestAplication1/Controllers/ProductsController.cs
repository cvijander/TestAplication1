using Microsoft.AspNetCore.Mvc;

namespace TestAplication1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewProducts()
        {
            return View();
        }
    }
}
