using EBS.WebUI.DTOs.AgenceDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class Agence1Controller : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAgenceDto>>("agences");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"agences/{id}");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAgenceDto createAgenceDto)
        {
            await _client.PostAsJsonAsync("agences", createAgenceDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAgence(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateAgenceDto>($"agences/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAgence(UpdateAgenceDto updateAgenceDto)
        {
            await _client.PutAsJsonAsync("agences", updateAgenceDto);
            return RedirectToAction(nameof(Index));
        } 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultAgenceDto>($"agences/{id}");
            return View(value);

        }

    }
}
