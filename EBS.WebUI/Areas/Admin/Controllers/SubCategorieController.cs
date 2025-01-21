using EBS.WebUI.DTOs.CategoryDtos;
using EBS.WebUI.DTOs.SubCategoryDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SubCategorieController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        
        public async Task CategoryDropDown()
        {
            var CategorieList = await _client.GetFromJsonAsync<List<ResultCategoryDto>>("Categories/GetActiveCategories");
            List<SelectListItem> CategorieSelectItem = (from x in CategorieList
                                                        select new SelectListItem
                                                     {
                                                         Text = x.Name,
                                                         Value = x.Id.ToString()

                                                     }).ToList();
            ViewBag.CategorieSelectItem = CategorieSelectItem;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultSubCategoryDto>>("SubCategories");
            return View(values);
        }

        public async Task<IActionResult> DeleteSubCategorie(int id)
        {
            await _client.DeleteAsync($"SubCategories/{id}");
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> CreateSubCategorie()
        {
            await CategoryDropDown();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubCategorie(CreateSubCategoryDto createSubCategorieDto)
        {
            await _client.PostAsJsonAsync("SubCategories", createSubCategorieDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateSubCategorie(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateSubCategoryDto>($"SubCategories/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSubCategorie(UpdateSubCategoryDto updateSubCategoryDto)
        {
            await _client.PutAsJsonAsync("SubCategories", updateSubCategoryDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultSubCategoryDto>($"SubCategories/{id}");
            return View(value);
        }


        public async Task<IActionResult> SubCategoryStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateSubCategoryDto>($"SubCategories/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("SubCategories", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> SubCategoryStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateSubCategoryDto>($"SubCategories/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("SubCategories", values);
            return RedirectToAction(nameof(Index));
        }

    }
}
