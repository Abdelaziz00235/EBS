using EBS.WebUI.DTOs.AgenceDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AgenceController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {  
            var values = await _client.GetFromJsonAsync<List<ResultAgenceDto>>("Agences");
            return View(values); 
        }

        public async Task<IActionResult> DeleteAgence(int id)
        {
            await _client.DeleteAsync($"Agences/{id}");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult CreateAgence()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAgence(CreateAgenceDto createAgenceDto)
        {
            await _client.PostAsJsonAsync("Agences", createAgenceDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAgence(int id)
        { 
            var values = await _client.GetFromJsonAsync<UpdateAgenceDto>($"Agences/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAgence(UpdateAgenceDto updateAgenceDto)
        { 
            await _client.PutAsJsonAsync("Agences", updateAgenceDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultAgenceDto>($"Agences/{id}");
            return View(value);
        }

        public async Task<IActionResult> AgenceChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateAgenceDto>($"Agences/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Agences", values);
            return RedirectToAction(nameof(Index));
        } 

        public async Task<IActionResult> AgenceChangeStautsIsTrue(int id)
        {

            var values = await _client.GetFromJsonAsync<UpdateAgenceDto>($"Agences/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Agences", values);
            return RedirectToAction(nameof(Index));
        }
    }
}
