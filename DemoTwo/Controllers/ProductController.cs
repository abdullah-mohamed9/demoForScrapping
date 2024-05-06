using Microsoft.AspNetCore.Mvc;

namespace DemoTwo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
