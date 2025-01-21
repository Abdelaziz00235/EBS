using EBS.WebUI.DTOs.AgenceDtos;
using EBS.WebUI.DTOs.DepartmentDtos;
using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task AgenceDropDown()
        {
            var productList = await _client.GetFromJsonAsync<List<ResultAgenceDto>>("Agences/GetActiveAgences");
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
            var DepartmentList = await _client.GetFromJsonAsync<List<ResultDepartmentDto>>("Departments/GetActiveDepartments");
            List<SelectListItem> departmentSelectItem = (from x in DepartmentList
                                                         select new SelectListItem
                                                     {
                                                         Text = x.Name,
                                                         Value = x.Id.ToString()

                                                     }).ToList();
            ViewBag.DepartmentSelectItem = departmentSelectItem;
        }
        
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultEmployeeDto>>("Employees");
            return View(values);
        }

        public async Task<IActionResult> CreateEmployee()
        {
            await AgenceDropDown();
            await DepartmentDropDown();
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto, IFormFile PictureImage)
        {
            if (createEmployeeDto.ImageUrl == null)
            {
                ModelState.AddModelError("ImageUrl", "The Image File is Required");
            }
            if (PictureImage != null)
            {
                var extension_file = Path.GetExtension(PictureImage.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                var NameFicture = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + createEmployeeDto.NNI.ToString();
                string NewImage = NameFicture + extension_file;

             
                var locationFile = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/EmployeesPicture/" + NewImage);
                using (var stream = new FileStream(locationFile, FileMode.Create))
                {
                    await PictureImage.CopyToAsync(stream);
                }
                createEmployeeDto.ImageUrl = NewImage;

            }

            await _client.PostAsJsonAsync("Employees", createEmployeeDto);
            return RedirectToAction(nameof(Index));

        }
         
        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            if (id != null)
            {
                await AgenceDropDown();
                await DepartmentDropDown();

                var values = await _client.GetFromJsonAsync<UpdateEmployeeDto>($"Employees/{id}");


                return View(values);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto, IFormFile? PictureImage)
        {
            if (PictureImage != null)
            {
                var extension_file = Path.GetExtension(PictureImage.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                var NameFicture = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + updateEmployeeDto.NNI.ToString();
                string NewImage = NameFicture + extension_file;


                var locationFile = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/EmployeesPicture/" + NewImage);
                using (var stream = new FileStream(locationFile, FileMode.Create))
                {
                    await PictureImage.CopyToAsync(stream);
                }
                updateEmployeeDto.ImageUrl = NewImage;
            }
             
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

            if (value != null)
            {
                var a = await _client.GetFromJsonAsync<ResultAgenceDto>($"Agences/{value.AgenceId}");
                var d = await _client.GetFromJsonAsync<ResultDepartmentDto>($"Departments/{value.DepartmentId}");

                if (a != null)
                {
                    ViewBag.AgenceSelectName = a.Name;
                }
                if (d != null)
                {
                    ViewBag.DepartmentSelectName = d.Name; 
                }
            }
            return View(value);
        }

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _client.DeleteAsync($"Employees/{id}");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> EmployeeChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateEmployeeDto>($"Employees/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Employees", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> EmployeeChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateEmployeeDto>($"Employees/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Employees", values);
            return RedirectToAction(nameof(Index));
        }
    }
}

