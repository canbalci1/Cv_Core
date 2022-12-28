using Microsoft.AspNetCore.Mvc;

namespace Cv_Core.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
