using EBS.WebUI.DTOs.BannerDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
            return View(values);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"banners/{id}");
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto createBannerDto  )
        {
            await _client.PostAsJsonAsync("banners", createBannerDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBannerDto>($"banners/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateBannerDto updateBannerDto)
        {
            await _client.PutAsJsonAsync("banners", updateBannerDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        { 
            var value = await _client.GetFromJsonAsync<ResultBannerDto>($"banners/{id}");
            return View(value);

        }

        public async Task<IActionResult> BannerChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBannerDto>($"Banners/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Banners", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> BannerChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBannerDto>($"Banners/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Banners", values);
            return RedirectToAction(nameof(Index));
        }

    }
}
