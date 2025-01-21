using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.DTOs.OrderDtos;
using EBS.WebUI.DTOs.ProductDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            //Nombre de sous-categorie 
            ViewBag.e = await _client.GetFromJsonAsync<int>("Products/SubCategoryCount");
            //quantite total des produits en stock
            ViewBag.SumQuantity = await _client.GetFromJsonAsync<int>("Products/ProductQuantitySum");

            var values = await _client.GetFromJsonAsync<List<ResultOrderDto>>("Orders");
            return View(values);
        } 
    }
}
