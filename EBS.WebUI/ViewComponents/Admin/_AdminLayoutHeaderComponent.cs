using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.ViewComponents.Admin
{
    public class _AdminLayoutHeaderComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
