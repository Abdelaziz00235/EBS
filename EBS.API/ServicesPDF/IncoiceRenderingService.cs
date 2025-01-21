using EBS.Entity.Entities;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace EBS.API.ServicesPDF
{
    public class IncoiceRenderingService
    {
        public IncoiceRenderingService()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }
        public byte[] GenerateInvoiceDpf(RequestPurchaseOrExecutionWork _requestPurchaseOrExecutionWork) 
        {
            var document = Document.Create(Container =>
            {
                Container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2,Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text("DEMANDE D'ACHAT DE MATERIEL OU D'EXECUSION DE TRAVAUX")
                        .SemiBold().FontSize(14)  
                        .FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);
                            x.Item().Text(Placeholders.LoremIpsum());
                            x.Item().Text("Abdoulaye Abdelaziz");
                            x.Item().Image(Placeholders.Image(200, 100));

                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page");
                            x.CurrentPageNumber();
                        });
                     
                });
                  
            });

            //document.ShowInCompanionAsync();
            document.ShowInCompanion();

            return document.GeneratePdf();
        }
    }
}
