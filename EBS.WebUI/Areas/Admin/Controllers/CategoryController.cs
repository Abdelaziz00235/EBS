using EBS.WebUI.DTOs.CategoryDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly HttpClient _client  = HttpClientInstance.CreateClient();
        // GET: CategoryController
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCategoryDto>>("categories");
            return View(values);
        }

        // GET: CategoryController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultCategoryDto>($"categories/{id}");
            return View(value);
        }

        // GET: CategoryController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost] 
        public async Task<IActionResult> Create(CreateCategoryDto createCategoryDto, IFormFile PictureIcon)
        {
            if (createCategoryDto.Icon == null)
            {
                ModelState.AddModelError("Icon:", "The Image File is Required");
            }
            if (PictureIcon != null)
            {
                var extension_file = Path.GetExtension(PictureIcon.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                var NameFicture = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + createCategoryDto.Id+"_"+createCategoryDto.Name.ToString();
                string NewImage = NameFicture + extension_file;

                var locationFile = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/CategoriesIcon/" + NewImage);
                using (var stream = new FileStream(locationFile, FileMode.Create))
                {
                    await PictureIcon.CopyToAsync(stream);
                }
                createCategoryDto.Icon = NewImage;
            }

            await _client.PostAsJsonAsync("categories", createCategoryDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateCategoryDto>($"categories/{id}");
            return View(value);
        }

         
        [HttpPost] 
        public async Task<IActionResult> Edit(UpdateCategoryDto updateCategoryDto, IFormFile PictureIcon)
        {
            if (updateCategoryDto.Icon == null)
            {
                ModelState.AddModelError("Icon:", "The Image File is Required");
            }
            if (PictureIcon != null)
            {
                var extension_file = Path.GetExtension(PictureIcon.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                var NameFicture = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + updateCategoryDto.Id + "_" + updateCategoryDto.Name.ToString();
                string NewImage = NameFicture + extension_file;

                var locationFile = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/CategoriesIcon/" + NewImage);
                using (var stream = new FileStream(locationFile, FileMode.Create))
                {
                    await PictureIcon.CopyToAsync(stream);
                }
                updateCategoryDto.Icon = NewImage;
            }
            await _client.PutAsJsonAsync("categories", updateCategoryDto);
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"categories/{id}");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> CategorieChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateCategoryDto>($"Categories/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Categories", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CategorieChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateCategoryDto>($"Categories/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Categories", values);
            return RedirectToAction(nameof(Index));
        }
    }
}
