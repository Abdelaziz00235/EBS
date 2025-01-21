using Bogus;
using EBS.API.ServicesPDF;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController(IncoiceRenderingService _incoiceRenderingService) : ControllerBase
    {
       
        [HttpGet("GeneratePdf")]
        public ActionResult GeneratePdf() 
        {
            /*
                Nature
                Maintenance
                GeneralService
                BudgetLine
                SupplierId
                CreatedById
                ValidatedById

             */
            var requestPurchaseOrExecutionWork = new Faker<RequestPurchaseOrExecutionWork>()
                .RuleFor(i => i.Nature, f =>f.Commerce.ProductName())
                .RuleFor(i =>i.Maintenance, f => f.Commerce.ProductName())
                .RuleFor(i =>i.GeneralService, f => f.Commerce.ProductName())
                .RuleFor(i =>i.BudgetLine, f => f.Commerce.Price().ToString() )
                .RuleFor(i =>i.SupplierId, f => f.Random.Int(1,10) )
                .RuleFor(i =>i.CreatedById, f => f.Random.Int(1,10) )
                .RuleFor(i =>i.ValidatedById, f => f.Random.Int(1,10) )
                .Generate();
            var document = _incoiceRenderingService.GenerateInvoiceDpf(requestPurchaseOrExecutionWork);

            return File(document,"application/pdf", "requestPurchaseOrExecutionWork.pdf");
        }
    }
}
