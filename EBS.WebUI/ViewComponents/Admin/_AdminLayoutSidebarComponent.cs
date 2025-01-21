using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.ViewComponents.Admin
{
    public class _AdminLayoutSidebarComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           return View();
        }
    }
}
