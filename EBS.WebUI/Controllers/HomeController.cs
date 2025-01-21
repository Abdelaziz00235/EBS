using EBS.WebUI.DTOs.ProductDtos;
using EBS.WebUI.Helpers;
using EBS.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace EBS.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        //public async Task SubCategoryDropDown()
        //{
        //    var subcategoryList = await _client.GetFromJsonAsync<List<ResultSubCategoryDto>>("SubCategories");
        //    List<SelectListItem> subCategories = (from x in subcategoryList
        //                                          select new SelectListItem
        //                                          {
        //                                              Text = x.Name,
        //                                              Value = x.Id.ToString()

        //                                          }).ToList();
        //    ViewBag.SubCategorySelectItem = subCategories;
        //}
        //public async Task PurchaseOrderDropDown()
        //{
        //    var purchaseOrderList = await _client.GetFromJsonAsync<List<ResultPurchaseOrderDto>>("PurchaseOrders");
        //    List<SelectListItem> _purchaseOrder = (from x in purchaseOrderList
        //                                           select new SelectListItem
        //                                           {
        //                                               Text = x.Name,
        //                                               Value = x.Id.ToString()
        //                                           }).ToList();
        //    ViewBag.purchaseOrderSelectItem = _purchaseOrder;
        //}
        //public async Task BrandDropDown()
        //{
        //    var BrandList = await _client.GetFromJsonAsync<List<ResultBrandDto>>("Brands");
        //    List<SelectListItem> _brand = (from x in BrandList
        //                                   select new SelectListItem
        //                                   {
        //                                       Text = x.Name,
        //                                       Value = x.Id.ToString()

        //                                   }).ToList();
        //    ViewBag.BrandSelectItem = _brand;
        //}

        public async Task<IActionResult> Index()
        {
            //await BrandDropDown();
            var values = await _client.GetFromJsonAsync<List<ResultProductDto>>("Products/GetActiveProducts");

            return View(values);
        }
        [HttpGet]
        public PartialViewResult PartialSearch()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialSearch(string _word)
        {
            TempData["word"] = _word;
            return RedirectToAction("ProductListWithSearch", "ProductHome");
        }
         
    } 
}
