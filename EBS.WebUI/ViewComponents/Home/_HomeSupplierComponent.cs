using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.ViewComponents.Home
{
    public class _HomeSupplierComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
