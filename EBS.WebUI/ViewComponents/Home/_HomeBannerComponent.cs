using EBS.WebUI.DTOs.SubCategoryDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.ViewComponents.Home
{
    public class _HomeBannerComponent : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task SubCategoryDropDown()
        {
            var subcategoryList = await _client.GetFromJsonAsync<List<ResultSubCategoryDto>>("SubCategories");
            List<SelectListItem> subCategories = (from x in subcategoryList
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name,
                                                      Value = x.Id.ToString()

                                                  }).ToList();
            ViewBag.subCategories = subCategories;
        } 

        public async Task<IViewComponentResult> InvokeAsync()
        {
            await SubCategoryDropDown(); 
            return View();
        }
    }
}
