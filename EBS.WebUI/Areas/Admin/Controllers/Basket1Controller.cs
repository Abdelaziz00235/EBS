using EBS.WebUI.DTOs.BasketDtos;
using EBS.WebUI.DTOs.ProductDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using EBS.WebUI.DTOs.EmployeeDtos;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class Basket1Controller : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task ProductDropDown()
        {
            var productList = await _client.GetFromJsonAsync<List<ResultProductDto>>("Products");
            List<SelectListItem> productSelectItem = (from x in productList
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()

                                           }).ToList();
            ViewBag.product = productSelectItem;
        }
        public async Task employeeDropDown()
        {
            var employeeList = await _client.GetFromJsonAsync<List<ResultEmployeeDto>>("Employees");
            List<SelectListItem> employeeSelectItem = (from e in employeeList
                                                       select new SelectListItem
                                                       {
                                                            Text = e.FullName,
                                                            Value = e.Id.ToString()

                                                       }).ToList();
            ViewBag.employeeSelectItem = employeeSelectItem;
        }


        // GET: BasketController
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBasketDto>>("Baskets");
            return View(values);
        }

        public async Task<IActionResult> DeleteBasket(int id)
        {
            await _client.DeleteAsync($"Baskets/{id}");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateBasket()
        {
            await ProductDropDown();
            await employeeDropDown();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBasket(CreateBasketDto createBasketDto)
        {
            await _client.PostAsJsonAsync("Baskets", createBasketDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBasket(int id)
        {
            await ProductDropDown();
            await employeeDropDown();

            var values = await _client.GetFromJsonAsync<UpdateBasketDto>($"Baskets/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBasket(UpdateBasketDto updateBasketDto)
        {
            await _client.PutAsJsonAsync("Baskets", updateBasketDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultBasketDto>($"Baskets/{id}");
            return View(value);
        }
    }
}
