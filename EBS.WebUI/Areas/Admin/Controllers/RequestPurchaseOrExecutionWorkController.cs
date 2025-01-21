using EBS.WebUI.DTOs.RequestPurchaseOrExecutionWorkDtos;
using EBS.WebUI.DTOs.SupplierDtos;
using EBS.WebUI.Helpers;
using EBS.WebUI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RequestPurchaseOrExecutionWorkController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task SupplierDropDown()
        {
            var supplierList = await _client.GetFromJsonAsync<List<ResultSupplierDto>>("suppliers");
            List<SelectListItem> productSelectItem = (from x in supplierList
                                                      select new SelectListItem
                                                      {
                                                          Text = $"{x.FullName} --[ {x.CompanyName} ]",
                                                          Value = x.Id.ToString()

                                                      }).ToList();
            ViewBag.SupplierSelectItem = productSelectItem;
        }
        public async Task<IActionResult> Index()
        { 
            var values = await _client.GetFromJsonAsync<List<ResultRequestPurchaseOrExecutionWorkDto>>("RequestPurchaseOrExecutionWorks");
            return View(values);
        }

        public async Task<IActionResult> DeleteRequestPurchaseOrExecutionWork(int id)
        {
            await _client.DeleteAsync($"RequestPurchaseOrExecutionWorks/{id}");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateRequestPurchaseOrExecutionWork()
        {
            await SupplierDropDown();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequestPurchaseOrExecutionWork(CreateRequestPurchaseOrExecutionWorkDto createRequestPurchaseOrExecutionWorkDto)
        {
            await _client.PostAsJsonAsync("RequestPurchaseOrExecutionWorks", createRequestPurchaseOrExecutionWorkDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateRequestPurchaseOrExecutionWork(int id)
        {
            await SupplierDropDown();
            var values = await _client.GetFromJsonAsync<UpdateRequestPurchaseOrExecutionWorkDto>($"RequestPurchaseOrExecutionWorks/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRequestPurchaseOrExecutionWork(UpdateRequestPurchaseOrExecutionWorkDto updateRequestPurchaseOrExecutionWorkDto)
        {
            await _client.PutAsJsonAsync("RequestPurchaseOrExecutionWorks", updateRequestPurchaseOrExecutionWorkDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> DetailsRequestPurchaseOrExecutionWork(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultRequestPurchaseOrExecutionWorkDto>($"RequestPurchaseOrExecutionWorks/{id}");
            return View(value);
        }


        public async Task<IActionResult> RequestPurchaseOrExecutionWorkChangeStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateRequestPurchaseOrExecutionWorkDto>($"RequestPurchaseOrExecutionWorks/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("RequestPurchaseOrExecutionWorks", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RequestPurchaseOrExecutionWorkChangeStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateRequestPurchaseOrExecutionWorkDto>($"RequestPurchaseOrExecutionWorks/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("RequestPurchaseOrExecutionWorks", values);
            return RedirectToAction(nameof(Index));
        }




        // Export pdf File

        

        //public IActionResult ExportPdfRequestPurchaseOrExecutionWork(int id)
        //{ 
        //    var pdfGenerato = new PdfGeneratorServices();
        //    var document = pdfGenerato.ExportPdfRequestPurchaseOrExecutionWork(id);

        //    MemoryStream stream = new MemoryStream();
        //    document.Save(stream);

        //    Response.ContentType = "application/pdf";
        //    Response.Headers.Add("content-length", stream.Length.ToString());
        //    byte[] bytes = stream.ToArray();
        //    stream.Close();

        //    return File(bytes, "application/pdf", $"RequestPurchaseOrExecutionWork_{id}.pdf");
        //}
    }
}
