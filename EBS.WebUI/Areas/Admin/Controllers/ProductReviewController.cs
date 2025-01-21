using EBS.WebUI.DTOs.ProductReviewDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ProductReviewController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultProductReviewDto>>("ProductReviews");
            return View(values);
        }

        public async Task<IActionResult> DeleteProductReview(int id)
        {
            await _client.DeleteAsync($"ProductReviews/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateProductReview()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductReview(CreateProductReviewDto createProductReviewDto)
        {
            await _client.PostAsJsonAsync("ProductReviews", createProductReviewDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateProductReview(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateProductReviewDto>($"ProductReviews/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductReview(UpdateProductReviewDto updateProductReviewDto)
        {
            await _client.PutAsJsonAsync("ProductReviews", updateProductReviewDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultProductReviewDto>($"ProductReviews/{id}");
            return View(value);
        }

    }
}
