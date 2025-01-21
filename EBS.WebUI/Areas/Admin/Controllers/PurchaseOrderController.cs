using EBS.WebUI.DTOs.PurchaseOrderDtos;
using EBS.WebUI.DTOs.SupplierDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class PurchaseOrderController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        
        public async Task SupplierDropDown()
        {
            var supplierList = await _client.GetFromJsonAsync<List<ResultSupplierDto>>("suppliers");
            List<SelectListItem> supplierSelectItem = (from x in supplierList
                                                      select new SelectListItem
                                                      {
                                                          Text = x.FullName,
                                                          Value = x.Id.ToString()

                                                      }).ToList();
            ViewBag.SupplierSelectItem = supplierSelectItem;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultPurchaseOrderDto>>("PurchaseOrders");
            return View(values);
        }

        public async Task<IActionResult> DeletePurchaseOrder(int id)
        {
            await _client.DeleteAsync($"PurchaseOrders/{id}");
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> CreatePurchaseOrder()
        {
            await SupplierDropDown();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePurchaseOrder(CreatePurchaseOrderDto createPurchaseOrderDto)
        {
            await _client.PostAsJsonAsync("PurchaseOrders", createPurchaseOrderDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePurchaseOrder(int id)
        {
            await SupplierDropDown();
            var values = await _client.GetFromJsonAsync<UpdatePurchaseOrderDto>($"PurchaseOrders/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePurchaseOrder(UpdatePurchaseOrderDto updatePurchaseOrderDto)
        {
            await _client.PutAsJsonAsync("PurchaseOrders", updatePurchaseOrderDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {

            if (id == 0)
            {
                return NotFound();
            }
            var value_ = await _client.GetFromJsonAsync<ResultPurchaseOrderDto>($"PurchaseOrders/{id}");

            if (value_ != null)
            {
                var s = await _client.GetFromJsonAsync<ResultSupplierDto>($"suppliers/{value_.SupplierId}"); 
                 
                if (s != null)
                {
                    ViewBag.supplierFullName = s.FullName;
                    ViewBag.supplierCompanyName = s.CompanyName;
                }

            }

            return View(value_);
        }

        public async Task<IActionResult> PurchaseOrderChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdatePurchaseOrderDto>($"PurchaseOrders/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("PurchaseOrders", values);
            return RedirectToAction(nameof(Index));
        }
         
        public async Task<IActionResult> PurchaseOrderChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdatePurchaseOrderDto>($"PurchaseOrders/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("PurchaseOrders", values);
            return RedirectToAction(nameof(Index));
        }

    }
}
