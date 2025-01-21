using EBS.WebUI.DTOs.BasketDtos;
using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.DTOs.ProductDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BasketController : Controller
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
            ViewBag.productSelectItem = productSelectItem;
        }
        public async Task EmployeeDropDown()
        {
            var employeeList = await _client.GetFromJsonAsync<List<ResultEmployeeDto>>("Employees");
            List<SelectListItem> employeeSelectItem = (from e in employeeList
                                                       select new SelectListItem
                                                       {
                                                           Text = e.FullName,
                                                           Value = e.Id.ToString()
                                                           
                                                       }
                                                       ).ToList();
            ViewBag.employeeSelectItem = employeeSelectItem;
        }


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
            await EmployeeDropDown(); 

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
            await EmployeeDropDown();

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

            if( value != null)
            {
                var p = await _client.GetFromJsonAsync<ResultProductDto>($"Products/{value.ProductId}");
                var e = await _client.GetFromJsonAsync<ResultEmployeeDto>($"Employees/{value.EmployeeId}");

                if (e != null) {
                    ViewBag.employeeName = e.FullName;
                    ViewBag.employeeImageUrl = e.ImageUrl;
                }
                if (p != null)
                {
                    ViewBag.productName = p.Name;
                    ViewBag.productImageUrl = p.ImageUrl;
                }

            }
            return View(value); 
        }


        public async Task<IActionResult> BasketChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBasketDto>($"Baskets/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Baskets", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> BasketChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBasketDto>($"Baskets/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Baskets", values);
            return RedirectToAction(nameof(Index));
        }
    }
}
