using EBS.WebUI.DTOs.BrandDtos;
using EBS.WebUI.DTOs.ProductDtos;
using EBS.WebUI.DTOs.PurchaseOrderDtos;
using EBS.WebUI.DTOs.SubCategoryDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Controllers
{
    public class ProductHomeController : Controller
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
            ViewBag.SubCategorySelectItem = subCategories;
        }
        public async Task PurchaseOrderDropDown()
        {
            var purchaseOrderList = await _client.GetFromJsonAsync<List<ResultPurchaseOrderDto>>("PurchaseOrders");
            List<SelectListItem> _purchaseOrder = (from x in purchaseOrderList
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.Id.ToString()
                                                   }).ToList();
            ViewBag.purchaseOrderSelectItem = _purchaseOrder;
        }
        public async Task BrandDropDown()
        {
            var BrandList = await _client.GetFromJsonAsync<List<ResultBrandDto>>("Brands");
            List<SelectListItem> _brand = (from x in BrandList
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()

                                           }).ToList();
            ViewBag.BrandSelectItem = _brand;
        }

        public async Task<IActionResult> Index()
        {
            await BrandDropDown();
            var values = await _client.GetFromJsonAsync<List<ResultProductDto>>("Products/GetActiveProducts");

            return View(values);
        }
        public async Task<IActionResult> ProductListWithSearch(string? searchKeyValue)
        {
            ViewBag.searchKeyword = TempData["word"];
            string searchKeyValue_ = (ViewBag.searchKeyword).ToString();

            if (searchKeyValue_ != null)
            {
                var values = await _client.GetFromJsonAsync<List<ResultProductDto>>($"Products/GetProductSearchKeyValueWithSubCategory?searchKeyValue={searchKeyValue_}");
                return View(values);
            }
            if (searchKeyValue != null)
            {
                var values = await _client.GetFromJsonAsync<List<ResultProductDto>>($"Products/GetProductSearchKeyValueWithSubCategory?searchKeyValue={searchKeyValue}");
                return View(values);
            }
            else
            {
                var values = await _client.GetFromJsonAsync<List<ResultProductDto>>("Products");
                return View(values);
            }
        }


        [HttpGet]
        public async Task<IActionResult> ProductSingle(int id)
        {
            var values = await _client.GetFromJsonAsync<ResultProductDto>($"Products/{id}");

            ViewBag.ProductTitle = values.Name;
            ViewBag.ProductShortDescription = values.ShortDescription;
            ViewBag.ProductLongDescription = values.LongDescription;

            ViewBag.Image =

            ViewBag.Image = values.ImageUrl;
            ViewBag.Image1 = values.ImageUrl1;
            ViewBag.Image2 = values.ImageUrl2;
            ViewBag.Image3 = values.ImageUrl3;
            ViewBag.Image4 = values.ImageUrl4;

            ViewBag.DateCreated = DateTime.Now.Year; 


            return View();
        }
    }
}
