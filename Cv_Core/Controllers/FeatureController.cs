using Microsoft.AspNetCore.Mvc;

namespace Cv_Core.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
