using EBS.WebUI.Helpers; 
using Microsoft.AspNetCore.Mvc;
using EBS.WebUI.DTOs.CategoryDtos;
using EBS.WebUI.DTOs.SupplierDtos;
using Microsoft.AspNetCore.Authorization;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SupplierController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        // GET: SupplierController
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultSupplierDto>>("suppliers");
            return View(values);
        }

        // GET: SupplierController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultSupplierDto>($"suppliers/{id}");
            return View(value);
        }

        // GET: SupplierController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateSupplierDto createSupplierDto  )
        {
            try
            {
                await _client.PostAsJsonAsync("suppliers", createSupplierDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateSupplierDto>($"suppliers/{id}");
            return View(value);
        }

         
        [HttpPost] 
        public async Task<IActionResult> Edit(UpdateSupplierDto updateSupplierDto)
        {
            try
            {
                await _client.PutAsJsonAsync("suppliers", updateSupplierDto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"suppliers/{id}");
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> SupplierStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateSupplierDto>($"Suppliers/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Suppliers", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> SupplierStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateSupplierDto>($"Suppliers/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Suppliers", values);
            return RedirectToAction(nameof(Index));
        }
    }
}
