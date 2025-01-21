using EBS.WebUI.DTOs.OrderDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.DTOs.ProductDtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

 
namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class OrderController : Controller
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
            var values = await _client.GetFromJsonAsync<List<ResultOrderDto>>("Orders");
            return View(values);
        }

        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _client.DeleteAsync($"Orders/{id}");
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrder()
        {
            await ProductDropDown();
            await EmployeeDropDown();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderDto createOrderDto)
        {
            await _client.PostAsJsonAsync("Orders", createOrderDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet] 
        public async Task<IActionResult> UpdateOrder(int id)
        {
            await ProductDropDown();
            await EmployeeDropDown();
            var values = await _client.GetFromJsonAsync<UpdateOrderDto>($"Orders/{id}");
            return View(values);
        }

        [HttpPost] 
        public async Task<IActionResult> UpdateOrder(UpdateOrderDto updateOrderDto)
        {
            await _client.PutAsJsonAsync("Orders", updateOrderDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultOrderDto>($"Orders/{id}");

            if (value != null)
            {
                var p = await _client.GetFromJsonAsync<ResultProductDto>($"Products/{value.ProductId}");
                var e = await _client.GetFromJsonAsync<ResultEmployeeDto>($"Employees/{value.EmployeeId}");

                if (e != null)
                {
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
            //if (id == 0)
            //{
            //    return NotFound();
            //}
            //var value = await _client.GetFromJsonAsync<ResultOrderDto>($"Orders/{id}");
            //return View(value);
        }

        public async Task<IActionResult> OrderChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateOrderDto>($"Orders/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Orders", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> OrderChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateOrderDto>($"Orders/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Orders", values);
            return RedirectToAction(nameof(Index));
        }

    }
}
