using Microsoft.AspNetCore.Mvc;

namespace WebApi2025.Controllers
{
    public class CountriesControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
