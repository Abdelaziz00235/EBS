using EBS.WebUI.DTOs.WitshListDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class WitshListController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultWitshListDto>>("WitshLists");
            return View(values);
        }

        public async Task<IActionResult> DeleteWitshList(int id)
        {
            await _client.DeleteAsync($"WitshLists/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateWitshList()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateWitshList(CreateWitshListDto createWitshListDto)
        {
            await _client.PostAsJsonAsync("WitshLists", createWitshListDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateWitshList(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateWitshListDto>($"WitshLists/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWitshList(UpdateWitshListDto updateWitshListDto)
        {
            await _client.PutAsJsonAsync("WitshLists", updateWitshListDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultWitshListDto>($"WitshLists/{id}");
            return View(value);
        }
    }
}
