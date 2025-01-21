using EBS.API.ServicesPDF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFController : ControllerBase
    {
        private readonly PdfGenerator _pdfGenerator;

        public PDFController(PdfGenerator pdfGenerator)
        {
            this._pdfGenerator = pdfGenerator;
        }

        [HttpPost]
        public IActionResult GeneratePdf()
        {
            string htmlContent = "<html>" +
                "<body>" +
                "   <h1>Hello, World!</h1>" +
                "<body>Aziz</body></html>";


            byte[] pdfBytes = _pdfGenerator.GeneratorPdf(htmlContent);

            return File(pdfBytes, "application/pdf", "generated.pdf");
        }
    }
}
