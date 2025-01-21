using EBS.Entity.Entities;
using EBS.WebUI.DTOs.OrderDtos;
using EBS.WebUI.DTOs.ProductDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Areas.Role1.Controllers
{
    [Authorize(Roles = "Role1")]
    [Area("Role1")]
    public class MyOrderController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        private readonly UserManager<Employee> _userManager;

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

        public MyOrderController(UserManager<Employee> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            int userId = (int) user.Id;
            var values = await _client.GetFromJsonAsync<List<ResultOrderDto>>($"Orders/GetOrdersByEmployeeId/{userId}");
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> CreateMyOrder()
        {
            await ProductDropDown(); 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMyOrder(CreateOrderDto createOrderDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            createOrderDto.EmployeeId = user.Id;
            createOrderDto.IsActived = false;
            await _client.PostAsJsonAsync("Orders", createOrderDto);
            return RedirectToAction(nameof(Index));

        }
    }
}
