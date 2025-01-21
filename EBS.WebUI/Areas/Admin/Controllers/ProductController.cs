using EBS.WebUI.DTOs.BrandDtos;
using EBS.WebUI.DTOs.ProductDtos;
using EBS.WebUI.DTOs.PurchaseOrderDtos;
using EBS.WebUI.DTOs.SubCategoryDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Json;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task SubCategoryDropDown()
        {
            var subcategoryList = await _client.GetFromJsonAsync<List<ResultSubCategoryDto>>("SubCategories");
            List<SelectListItem> subCategories = (from x in  subcategoryList
                                                  select new SelectListItem
                                                  {
                                                    Text = x.Name,
                                                    Value = x.Id.ToString()

                                                  } ).ToList();
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
            var values = await _client.GetFromJsonAsync<List<ResultProductDto>>("Products");
            
            return View(values);
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _client.DeleteAsync($"Products/{id}");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            await  SubCategoryDropDown();
            await PurchaseOrderDropDown();  
            await BrandDropDown(); 

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _client.PostAsJsonAsync("Products", createProductDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            await SubCategoryDropDown();
            await PurchaseOrderDropDown();
            await BrandDropDown();

            var values = await _client.GetFromJsonAsync<UpdateProductDto>($"Products/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _client.PutAsJsonAsync("Products", updateProductDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultProductDto>($"Products/{id}");
            return View(value);
        }
        
         
         
       
        public async Task<IActionResult> ProductChangeStautsIsTrue(int id)
        { 

            var values = await _client.GetFromJsonAsync<UpdateProductDto>($"Products/{id}");
            
            if (values.IsActived ==false) { 
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Products", values);
            return RedirectToAction(nameof(Index));
        }
         
         

        public async Task<IActionResult> ProductChangeStautsIsFalse(int id) {
            var values = await _client.GetFromJsonAsync<UpdateProductDto>($"Products/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Products", values);
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> ProductChangeReviewIsTrue(int id)
        {

            var values = await _client.GetFromJsonAsync<UpdateProductDto>($"Products/{id}");

            if (values.Review == false)
            {
                values.Review = true;
            }
            await _client.PutAsJsonAsync("Products", values);
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> ProductChangeReviewIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateProductDto>($"Products/{id}");

            if (values.Review == true)
            {
                values.Review = false;
            }
            await _client.PutAsJsonAsync("Products", values);
            return RedirectToAction(nameof(Index));
        }

    }
}
