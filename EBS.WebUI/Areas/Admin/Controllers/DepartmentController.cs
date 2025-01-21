using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using EBS.WebUI.DTOs.DepartmentDtos;
using Microsoft.AspNetCore.Authorization;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class DepartmentController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        // GET: DepartmentController
        public   async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultDepartmentDto>>("departments");
            return View(values);
        }
         
        public  async Task<IActionResult> DetailsDepartment(int id)
        {
            var value = await _client.GetFromJsonAsync<ResultDepartmentDto>($"departments/{id}");
            return View(value);
        }

        public IActionResult CreateDepartment()
        {
            return View();
        }

       
        [HttpPost] 
        public  async Task<IActionResult> CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            await _client.PostAsJsonAsync("departments", createDepartmentDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public  async Task<IActionResult> UpdateDepartment(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateDepartmentDto>($"departments/{id}");
            return View(values);
        }
         
        [HttpPost] 
        public  async Task<IActionResult> UpdateDepartment(UpdateDepartmentDto updateDepartmentDto )
        {
            await _client.PutAsJsonAsync("departments", updateDepartmentDto);
            return RedirectToAction(nameof(Index));
        }
         
        public  async Task<IActionResult> DeleteDepartment(int id)
        {
            await _client.DeleteAsync($"departments/{id}");
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> DepartmentChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateDepartmentDto>($"Departments/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Departments", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DepartmentChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateDepartmentDto>($"Departments/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Departments", values);
            return RedirectToAction(nameof(Index));
        }
    }
}
