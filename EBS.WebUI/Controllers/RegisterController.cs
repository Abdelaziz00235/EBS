using EBS.WebUI.DTOs.AgenceDtos;
using EBS.WebUI.DTOs.DepartmentDtos;
using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.Helpers;
using EBS.WebUI.Services.EmployeeServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RegisterController(IEmployeeService _employeeService) : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task AgenceDropDown()
        {
            var productList = await _client.GetFromJsonAsync<List<ResultAgenceDto>>("Agences");
            List<SelectListItem> agenceSelectItem = (from x in productList
                                                     select new SelectListItem
                                                     {
                                                         Text = x.Name,
                                                         Value = x.Id.ToString()

                                                     }).ToList();
            ViewBag.AgenceSelectItem = agenceSelectItem;
        }
        public async Task DepartmentDropDown()
        {
            var DepartmentList = await _client.GetFromJsonAsync<List<ResultDepartmentDto>>("Departments");
            List<SelectListItem> departmentSelectItem = (from x in DepartmentList
                                                         select new SelectListItem
                                                         {
                                                             Text = x.Name,
                                                             Value = x.Id.ToString()

                                                         }).ToList();
            ViewBag.DepartmentSelectItem = departmentSelectItem;
        }
        public async Task<IActionResult> SignupAsync()
        {
            await AgenceDropDown();
            await DepartmentDropDown();

            return View();
        }
        [HttpPost] 
        public async Task<IActionResult> Signup(EmployeeRegisterDto employeeRegister)
        {
            await AgenceDropDown();
            await DepartmentDropDown();

            var result =await _employeeService.CreateEmployeeAsync(employeeRegister); 
            if (!result.Succeeded || !ModelState.IsValid) 
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            return RedirectToAction("SignIn", "Login");
        }
    }
}
