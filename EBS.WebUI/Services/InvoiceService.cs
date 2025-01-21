using EBS.WebUI.Helpers;

namespace EBS.WebUI.Services
{
    public class InvoiceService
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();


        
         //public PdfDocument ExportPdfRequestPurchaseOrExecutionWork(Int32 id)
         //{
         //   const string filename = "DEMANDE D'ACHAT DE MATERIEL OU D'EXECUSION DE TRAVEAUX";
         //   // Create a new MigraDoc document
         //   var document = new Document();

         //   //BuilRequestPurchaseOrExecutionWorkDocument(document);
         //   BuilRequestPurchaseOrExecutionWorkDocument(document, id);

         //   var pdfRender = new PdfDocumentRenderer();
         //   pdfRender.Document = document;

         //   pdfRender.RenderDocument();

         //   return pdfRender.PdfDocument;
         //}



        //public PdfDocument GetInvoice(Int32 id)
        //{
        //    // Create a new MigraDoc document
        //    var document = new Document();  
        //    //BuilDocument(document);
        //    BuilDocument2(document,id);

        //    var pdfRender = new PdfDocumentRenderer();
        //    pdfRender.Document = document;

        //    pdfRender.RenderDocument();

        //    return pdfRender.PdfDocument;
        //}

        

        //private void BuilRequestPurchaseOrExecutionWorkDocument(Document document,int id)
        //{

        //    //New section
        //    Section section = document.AddSection();
        //    var paragraph = section.AddParagraph();


        //    paragraph.AddText("DEMANDE D'ACHAT DE MATERIEL OU D'EXECUSION DE TRAVEAUX");
        //    paragraph.AddLineBreak();
        //    paragraph.Format.SpaceAfter = 40;

        //    //New paragraph
        //    paragraph.AddText("DIRECTION GENERAL");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("ECOBANK BUSINESS SERVICES");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("ebsinfo@ecobank.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Tel: 66 63 64 68");
        //    paragraph.Format.SpaceAfter = 20;

        //    //New paragraph
        //    paragraph = section.AddParagraph();
        //    paragraph.AddText("Nom et Prenom: ABDOULAYE ABDELAZIZ");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Adresse: N'Djamena-Tchad");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("E-mail:  abdoulayeabdelaziz94@gmail.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Tel et WhatsApp:(+235) 66 63 64 68");
        //    paragraph.Format.SpaceAfter = 20;


        //    string[,] products =
        //    {
        //        {"1","Aziz","2","100 000 Fcfa","200 0000 Fcfa" },
        //        {"1","Aziza","2","100 000 Fcfa","200 0000 Fcfa" },
        //        {"1","Azizou","2","100 000 Fcfa","200 0000 Fcfa" },
        //        {"1","Azizo","2","100 000 Fcfa","200 0000 Fcfa" },
        //    };
        //    var table = document.LastSection.AddTable();
        //    table.Borders.Width = 0.5;

        //    table.AddColumn("1Cm");
        //    table.AddColumn("9Cm");
        //    table.AddColumn("2Cm");
        //    table.AddColumn("2Cm");
        //    table.AddColumn("2Cm");

        //    Row row = table.AddRow();

        //    row.HeadingFormat = true;
        //    row.Format.Font.Bold = true;
        //    row.Cells[0].AddParagraph("No");
        //    row.Cells[1].AddParagraph("Items");
        //    row.Cells[2].AddParagraph("Quantity");
        //    row.Cells[3].AddParagraph("Unit Price");
        //    row.Cells[4].AddParagraph("TOTAL");

        //    for (int i = 0; i < products.GetLength(0); i++)
        //    {
        //        row = table.AddRow();
        //        row.Cells[0].AddParagraph(products[i, 0]);
        //        row.Cells[1].AddParagraph(products[i, 1]);
        //        row.Cells[2].AddParagraph(products[i, 2]);
        //        row.Cells[3].AddParagraph(products[i, 3]);
        //        row.Cells[4].AddParagraph(products[i, 4]);
        //    }

        //    paragraph = section.AddParagraph();
        //    paragraph.AddText("Subtotal: 800 000 Fcfa");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Shipping Fee: 600 Fcfa");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Total: 1 600 000");
        //    paragraph.AddLineBreak();
        //    paragraph.Format.SpaceAfter = 20;

        //    paragraph = section.Footers.Primary.AddParagraph();
        //    paragraph.AddText("Ecobank Business Services | N'Djamena Tchad");
        //    paragraph.Format.Alignment = ParagraphAlignment.Center;

        //}


        //private void BuilDocument(Document document)
        //{
        //    //New section
        //    Section section = document.AddSection();

        //    //New paragraph
        //    var paragraph = section.AddParagraph();
        //    paragraph.AddText("Ecobank Tchad");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("www.ecobanktchad.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("ebsinfo@ecobank.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Tel: 66 63 64 68");
        //    paragraph.Format.SpaceAfter = 20;

        //    //New paragraph
        //    paragraph = section.AddParagraph();
        //    paragraph.AddText("Nom et Prenom: ABDOULAYE ABDELAZIZ");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Adresse: N'Djamena-Tchad");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("E-mail:  abdoulayeabdelaziz94@gmail.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Tel et WhatsApp:(+235) 66 63 64 68");
        //    paragraph.Format.SpaceAfter = 20;


        //    string[,] products =
        //    {
        //        {"1","Aziz","2","100 000 Fcfa","200 0000 Fcfa" },
        //        {"1","Aziza","2","100 000 Fcfa","200 0000 Fcfa" },
        //        {"1","Azizou","2","100 000 Fcfa","200 0000 Fcfa" },
        //        {"1","Azizo","2","100 000 Fcfa","200 0000 Fcfa" },
        //    };
        //    var table = document.LastSection.AddTable();
        //    table.Borders.Width = 0.5;

        //    table.AddColumn("1Cm");
        //    table.AddColumn("9Cm");
        //    table.AddColumn("2Cm");
        //    table.AddColumn("2Cm");
        //    table.AddColumn("2Cm");

        //    Row row = table.AddRow();

        //    row.HeadingFormat = true;
        //    row.Format.Font.Bold = true;
        //    row.Cells[0].AddParagraph("No");
        //    row.Cells[1].AddParagraph("Items");
        //    row.Cells[2].AddParagraph("Quantity");
        //    row.Cells[3].AddParagraph("Unit Price");
        //    row.Cells[4].AddParagraph("TOTAL");

        //    for (int i = 0; i < products.GetLength(0); i++)
        //    {
        //        row = table.AddRow();
        //        row.Cells[0].AddParagraph(products[i, 0]);
        //        row.Cells[1].AddParagraph(products[i, 1]);
        //        row.Cells[2].AddParagraph(products[i, 2]);
        //        row.Cells[3].AddParagraph(products[i, 3]);
        //        row.Cells[4].AddParagraph(products[i, 4]);
        //    }

        //    paragraph = section.AddParagraph();
        //    paragraph.AddText("Subtotal: 800 000 Fcfa");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Shipping Fee: 600 Fcfa");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Total: 1 600 000");
        //    paragraph.AddLineBreak();
        //    paragraph.Format.SpaceAfter = 20;

        //    paragraph = section.Footers.Primary.AddParagraph();
        //    paragraph.AddText("Ecobank Business Services | N'Djamena Tchad");
        //    paragraph.Format.Alignment = ParagraphAlignment.Center;

        //}

        //private void BuilDocument2(Document document,int id)
        //{
            

        //    //New section
        //    Section section = document.AddSection();
        //    var paragraph1 = section.AddParagraph();
        //    paragraph1.AddText("Ecobank Tchad_" + id); 
            
        //    paragraph1.AddLineBreak();

        //    //C: \Users\lenovo\source\repos\API\EBS_01\EBS.WebUI\wwwroot\EBSShopTemplate\assets\images\ebslogo\EcobankBusinessServices.png
        //    Image image = section.Headers.Primary.AddImage("C: //Users//lenovo//source//repos//API//EBS_01//EBS.WebUI//wwwroot//EBSShopTemplate//assets//images//ebslogo//EcobankBusinessServices.png");
        //    image.Height = "2.5cm";
        //    image.LockAspectRatio = true;
        //    image.RelativeVertical = RelativeVertical.Margin;
        //    image.RelativeHorizontal = RelativeHorizontal.Margin;
        //    image.Top=ShapePosition.Top;
        //    image.Left = ShapePosition.Right;
        //    image.WrapFormat.Style = WrapStyle.Through;

        //    //New paragraph
        //    var paragraph = section.AddParagraph();
        //    paragraph.AddText("Ecobank Tchad_"+id);
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("www.ecobanktchad.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("ebsinfo@ecobank.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Tel: 66 63 64 68");
        //    paragraph.Format.SpaceAfter = 20;

        //    //New paragraph
        //    paragraph = section.AddParagraph();
        //    paragraph.AddText("Nom et Prenom: ABDOULAYE ABDELAZIZ");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Adresse: N'Djamena-Tchad");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("E-mail:  abdoulayeabdelaziz94@gmail.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Tel et WhatsApp:(+235) 66 63 64 68");
        //    paragraph.Format.SpaceAfter = 20;

             
        //    var table = document.LastSection.AddTable();
        //    table.Borders.Width = 0.5;

        //    table.AddColumn("1Cm");
        //    table.AddColumn("7Cm");
        //    table.AddColumn("2Cm");
        //    table.AddColumn("2Cm");
        //    table.AddColumn("2Cm");
        //    table.AddColumn("2Cm");

        //    Row row = table.AddRow();

        //    row.HeadingFormat = true;
        //    row.Format.Font.Bold = true;
        //    row.Cells[0].AddParagraph("#");
        //    row.Cells[1].AddParagraph("Description");
        //    row.Cells[2].AddParagraph("Item 1");
        //    row.Cells[3].AddParagraph("Item 2");
        //    row.Cells[4].AddParagraph("Item 3");
        //    row.Cells[5].AddParagraph("Item 4");
             
        //    var value = _client.GetFromJsonAsync<ResultAboutDto>($"abouts/{id}");

        //    row = table.AddRow();
        //    row.Cells[0].AddParagraph(value.Result.Id.ToString()); 
        //    row.Cells[1].AddParagraph(value.Result.description); 
        //    row.Cells[2].AddParagraph(value.Result.Item1); 
        //    row.Cells[3].AddParagraph(value.Result.Item2); 
        //    row.Cells[4].AddParagraph(value.Result.Item3);
        //    row.Cells[5].AddParagraph(value.Result.Item4);
        //    paragraph.Format.SpaceAfter = 40;
             
        //    paragraph = section.AddParagraph();
        //    paragraph.AddText("Subtotal: 800 000 Fcfa");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Shipping Fee: 600 Fcfa");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Total: 1 600 000");
        //    paragraph.AddLineBreak();
        //    paragraph.Format.SpaceAfter = 20;

        //    paragraph = section.Footers.Primary.AddParagraph();
        //    paragraph.AddText("Ecobank Tchad");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Avenue Charles de Gaulle B.P: 87, N'Djamena");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("Tel: (+235) 2252 43 14/21 ou (+235) 2252 56 84 ou (+235) 2252 24 06 Fax:(+235) 2252 23 45 Email: ecobanktd.com");
        //    paragraph.AddLineBreak();
        //    paragraph.AddText("www.ecobank.com"); 
        //    paragraph.Format.Alignment = ParagraphAlignment.Left;

        //}

    }
}
