using Microsoft.AspNetCore.Mvc;

namespace Cv_Core.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
