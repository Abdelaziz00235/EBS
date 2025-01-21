using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
