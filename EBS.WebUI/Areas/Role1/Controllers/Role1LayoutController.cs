using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Role1.Controllers
{
    //[Authorize(Roles = "Role1")]
    //[Area("Role1")]
    public class Role1LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
