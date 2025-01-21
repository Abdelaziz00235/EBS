using EBS.WebUI.DTOs.AboutDtos;
using EBS.WebUI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EBS.WebUI.Services;



namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    //[Route("[area]/[controller]/[action]/{id?}")]
     
    public class AboutController() : Controller
    {
        private string lastImage1 = "";
        private string lastImage2 = "";

        private readonly HttpClient _client = HttpClientInstance.CreateClient();
         
        //public IActionResult ExportPdfAboutWithId(int id)
        //{ 
        //    var pdfGenerato = new PdfGeneratorServices();
        //    var document = pdfGenerato.CreateDocumentWithId();

        //    MemoryStream stream = new MemoryStream();
        //    document.Save(stream);

        //    Response.ContentType = "application/pdf";
        //    Response.Headers.Add("content-length", stream.Length.ToString());
        //    byte[] bytes = stream.ToArray();
        //    stream.Close();

        //    return File(bytes, "application/pdf", $"about{id}.pdf");
        //}
        //public IActionResult ExportPdfAbout(int id)
        //{
        //    int _id = id;
        //    var invoiceService = new InvoiceService();
        //    var document = invoiceService.GetInvoice(id);

        //    MemoryStream stream = new MemoryStream();
        //    document.Save(stream);

        //    Response.ContentType = "application/pdf";
        //    Response.Headers.Add("content-length",stream.Length.ToString());
        //    byte[] bytes = stream.ToArray();
        //    stream.Close();

        //    return File(bytes, "application/pdf", $"about{id}.pdf");
        //}
         
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
            return View(values);
        }
        
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _client.DeleteAsync($"abouts/{id}");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto, IFormFile? PictureImage1, IFormFile? PictureImage2)
        {
            if (createAboutDto.ImageUrl1 == null && createAboutDto.ImageUrl2 == null)
            {
                ModelState.AddModelError("ImageUrl", "The Image File is Required");
            }
            if (PictureImage1 != null )
            {
                var extension_file = Path.GetExtension(PictureImage1.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                //var NameFicture = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + createAboutDto.Id.ToString();
                var NameFicture1 = createAboutDto.Item1.ToString();
                string NewImage = NameFicture1 + "_1" + extension_file;


                var locationFile = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/AboutsPicture/" + NewImage);
                using (var stream = new FileStream(locationFile, FileMode.Create))
                {
                    await PictureImage1.CopyToAsync(stream);
                }
                createAboutDto.ImageUrl1 = NewImage;
            }
            if (PictureImage2 != null)
            {
                var extension_file = Path.GetExtension(PictureImage2.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                //var NameFicture = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + createAboutDto.Id.ToString();
                var NameFicture2 = createAboutDto.Item1.ToString();
                string NewImage = NameFicture2 + "_2" + extension_file;


                var locationFile = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/AboutsPicture/" + NewImage);
                using (var stream = new FileStream(locationFile, FileMode.Create))
                {
                    await PictureImage2.CopyToAsync(stream);
                }
                createAboutDto.ImageUrl2 = NewImage;
            }

            await _client.PostAsJsonAsync("abouts", createAboutDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {

            var values = await _client.GetFromJsonAsync<UpdateAboutDto>($"abouts/{id}");
            
            //lastImage1 = values.ImageUrl1;
            //lastImage2 = values.ImageUrl2;

            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto, IFormFile PictureImage1, IFormFile PictureImage2)
        {
            
            if (updateAboutDto.ImageUrl1 == null && updateAboutDto.ImageUrl2 == null)
            {
                ModelState.AddModelError("ImageUrl", "The Image File is Required");
            }
            if (PictureImage1 != null)
            {
                var extension_file1 = Path.GetExtension(PictureImage1.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                //var NameFicture1 = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + updateAboutDto.Id.ToString();
                var NameFicture1 = updateAboutDto.Item1.ToString();
                string NewImage1 = NameFicture1 + "_1" + extension_file1;


                var locationFile1 = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/AboutsPicture/" + NewImage1);
                using (var stream1 = new FileStream(locationFile1, FileMode.Create))
                {
                    await PictureImage1.CopyToAsync(stream1);
                }

                updateAboutDto.ImageUrl1 = NewImage1;
            }
            //else
            //{
            //    updateAboutDto.ImageUrl1 = lastImage1;
            //}
            
            if (PictureImage2 != null)
            {
                var extension_file2 = Path.GetExtension(PictureImage2.FileName);
                //var NameFicture = DateTime.Now.ToString("dd_MM_yyyy_HH_MM_ss") + Guid.NewGuid().ToString();
                //var NameFicture2 = DateTime.Now.ToString("ddMMyyyy_HHMMss_") + updateAboutDto.Id.ToString();
                var NameFicture2 = updateAboutDto.Item1.ToString();
                string NewImage2 = NameFicture2 + "_2" + extension_file2;

                var locationFile2 = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/AdminTemplate/assets/AboutsPicture/" + NewImage2);
                using (var stream2 = new FileStream(locationFile2, FileMode.Create))
                {
                    await PictureImage2.CopyToAsync(stream2);
                }
                updateAboutDto.ImageUrl2 = NewImage2;
            }
            //else
            //{
            //    updateAboutDto.ImageUrl1 = lastImage2;
            //}
            await _client.PutAsJsonAsync("abouts",updateAboutDto);

            return RedirectToAction(nameof(Index));
        }

       
        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var value = await _client.GetFromJsonAsync<ResultAboutDto>($"abouts/{id}");
            return View(value);
        }
         

        public async Task<IActionResult> AboutStautsIsFalse(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateAboutDto>($"Abouts/{id}");

            if (values.IsActived == true)
            {
                values.IsActived = false;
            }
            await _client.PutAsJsonAsync("Abouts", values);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AboutStautsIsTrue(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateAboutDto>($"Abouts/{id}");

            if (values.IsActived == false)
            {
                values.IsActived = true;
            }
            await _client.PutAsJsonAsync("Abouts", values);
            return RedirectToAction(nameof(Index));
        }
    }
}
