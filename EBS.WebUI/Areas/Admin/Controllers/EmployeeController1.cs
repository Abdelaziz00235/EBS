using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class EmployeeController1 : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultEmployeeDto>>("Employees");
            return View(values);
        }

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _client.DeleteAsync($"Employees/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            await _client.PostAsJsonAsync("Employees", createEmployeeDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateEmployeeDto>($"Employees/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            await _client.PutAsJsonAsync("Employees", updateEmployeeDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultEmployeeDto>($"Employees/{id}");
            return View(value);
        }
    }
}
