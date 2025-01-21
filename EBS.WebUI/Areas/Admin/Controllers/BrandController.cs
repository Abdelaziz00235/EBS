using EBS.WebUI.DTOs.BrandDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();


        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBrandDto>>("brands");
            return View(values);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"brands/{id}");
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateBrandDto createBrandDto)
        {
            await _client.PostAsJsonAsync("brands", createBrandDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateBrandDto>($"brands/{id}");
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateBrandDto updateBrandDto)
        {
            await _client.PutAsJsonAsync("brands", updateBrandDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            var value = await _client.GetFromJsonAsync<ResultBrandDto>($"brands/{id}");
            return View(value);

        }


        public async Task<IActionResult> BrandChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBrandDto>($"Brands/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Brands", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> BrandChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBrandDto>($"Brands/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Brands", values);
            return RedirectToAction(nameof(Index));
        }



    }
}
