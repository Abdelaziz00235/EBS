namespace EBS.WebUI.Services
{
    public class PdfGeneratorServices
    {
      //  public PdfDocument ExportPdfRequestPurchaseOrExecutionWork(int id)
      //  {
      //      // Create a new MigraDoc document
      //      var document = new Document();

      //      //New section
      //      Section section = document.AddSection();
      //      section.PageSetup.OddAndEvenPagesHeaderFooter = true;
      //      section.PageSetup.StartingNumber = 1;

      //      HeaderFooter header = section.Headers.Primary;
      //      header.AddParagraph("\tEcobank Business Service");
      //      header = section.Headers.EvenPage;
      //      header.Format.Alignment = ParagraphAlignment.Right;
             
      //      var paragraph_Header = section.AddParagraph();
      //      var paragraph_Body = section.AddParagraph();
      //      var paragraph_Footer = section.AddParagraph();

      //      var paragraph = section.AddParagraph();



      //      var paragraph_DESCRIPTION = section.AddParagraph();
      //      var paragraph_MOTIFS = section.AddParagraph();
      //      var paragraph_NATURE = section.AddParagraph();

      //      //ACHAT
      //      var paragraph_ACHAT_Title = section.AddParagraph();
      //      var paragraph_ACHAT_Content = section.AddParagraph();

      //      paragraph_ACHAT_Title.Format.Font.Bold = true;
      //      paragraph_ACHAT_Title.Format.Font.Italic = true;


      //      paragraph_ACHAT_Title.Format.Alignment = ParagraphAlignment.Left;

      //      //ENTRETIEN

      //      var paragraph_ENTRETIEN_Title = section.AddParagraph();
      //      var paragraph_ENTRETIEN_Content = section.AddParagraph();

      //      paragraph_ENTRETIEN_Title.Format.Font.Bold = true;
      //      paragraph_ENTRETIEN_Title.Format.Font.Italic = true;

      //      paragraph_ENTRETIEN_Title.Format.Alignment = ParagraphAlignment.Left;

 


      //      paragraph_Header.Format.Font.Bold = true;
      //      paragraph_Header.Format.Font.Italic = true;
      //      paragraph_Header.Format.Font.Size = 12;
      //      paragraph_Header.AddText("DEMANDE D'ACHAT DE MATERIEL OU D'EXECUSION DE TRAVEAUX");
      //      paragraph_Header.AddLineBreak();

           


      //      paragraph_DESCRIPTION.AddText("DESCRIPTION MATERIEL OU TRAVEAUX A EXECUTER: ");
      //      paragraph_MOTIFS.AddText("[Tasse a cafe et Cuilleres]");
      //      paragraph_MOTIFS.AddLineBreak();
      //      paragraph_MOTIFS.Format.SpaceAfter = 0;

      //      paragraph_MOTIFS.AddText("MOTIFS INVOQUES: ");
      //      paragraph_MOTIFS.AddText("[Ancien Unitilisables] ");
      //      paragraph_MOTIFS.AddLineBreak();
      //      paragraph_MOTIFS.Format.SpaceAfter = 20;

      //      paragraph_NATURE.Format.Font.Bold= true;
      //      paragraph_NATURE.AddText("NATURE DE LA DEMANDE");
      //      paragraph_NATURE.AddLineBreak();
      //      paragraph_NATURE.Format.SpaceAfter = 20;


      //      // ------------  ACHAT 
      //      // AddFormattedText("Achat", TextFormat.Underline)
            
      //      paragraph_ACHAT_Title.AddFormattedText("ACHAT",TextFormat.Underline);
      //      paragraph_ACHAT_Title.AddTab(); 
      //      paragraph_ACHAT_Title.Format.SpaceAfter = 10;

      //      //paragraph_ACHAT_Title.Format.Alignment = ParagraphAlignment.Left;
      //      //paragraph_ACHAT_Title.AddText("ENTRETIEN");
      //      //paragraph_ACHAT_Title.AddLineBreak();
      //      //paragraph_ACHAT_Title.Format.SpaceAfter = 20;

      //      paragraph_ACHAT_Content.AddText("Materiel / Mobilier de Bureau");
      //      paragraph_ACHAT_Content.AddLineBreak();
      //      paragraph_ACHAT_Content.Format.SpaceAfter = 20;

      //      paragraph_ACHAT_Content.AddText("Materiel / Mobilier de logements");
      //      paragraph_ACHAT_Content.AddLineBreak();
      //      paragraph_ACHAT_Content.Format.SpaceAfter = 20;

      //      paragraph_ACHAT_Content.AddText("Agencements Installation Banque");
      //      paragraph_ACHAT_Content.AddLineBreak();
      //      paragraph_ACHAT_Title.Format.SpaceAfter = 20;

      //      paragraph_ACHAT_Content.AddText("Materiel Informatique / Telephonique");
      //      paragraph_ACHAT_Content.AddLineBreak();
      //      paragraph_ACHAT_Content.Format.SpaceAfter = 20;

      //      paragraph_ACHAT_Content.AddText("Logiciel Informatique");
      //      paragraph_ACHAT_Content.AddLineBreak();
      //      paragraph_ACHAT_Content.Format.SpaceAfter = 20;

      //      paragraph_ACHAT_Content.AddText("Services Informatique / Telephonique");
      //      paragraph_ACHAT_Content.AddLineBreak();
      //      paragraph_ACHAT_Content.Format.SpaceAfter = 20;
      //      // ------------ AND ACHAT

      //      // ------------  ENTRETIEN 
            
      //      Image image = section.Headers.Primary.AddImage("C: //Users//lenovo//source//repos//API//EBS_01//EBS.WebUI//wwwroot//EBSShopTemplate//assets//images//ebslogo//EcobankBusinessServices.png");
      //      image.Height = "2.5cm";
      //      image.LockAspectRatio = true;
      //      image.RelativeVertical = RelativeVertical.Margin;
      //      image.RelativeHorizontal = RelativeHorizontal.Margin;
      //      image.Top = ShapePosition.Top;
      //      image.Left = ShapePosition.Right;
      //      image.WrapFormat.Style = WrapStyle.Through;



      //      paragraph_ENTRETIEN_Title.AddText("ENTRETIEN");
      //      paragraph_ENTRETIEN_Content.AddLineBreak();
      //      paragraph_ENTRETIEN_Content.Format.SpaceAfter = 20;

      //      paragraph_ENTRETIEN_Content.AddText("Banque");
      //      paragraph_ENTRETIEN_Content.AddLineBreak();
      //      paragraph_ENTRETIEN_Content.Format.SpaceAfter = 20;

      //      paragraph_ENTRETIEN_Content.AddText("Logements");
      //      paragraph_ENTRETIEN_Content.AddLineBreak();
      //      paragraph_ENTRETIEN_Content.Format.SpaceAfter = 20;

      //      paragraph_ENTRETIEN_Content.AddText("Vehicules");
      //      paragraph_ENTRETIEN_Content.AddLineBreak();
      //      paragraph_ACHAT_Title.Format.SpaceAfter = 20;

      //      paragraph_ENTRETIEN_Content.AddText("Materiel & Mobilier banque");
      //      paragraph_ENTRETIEN_Content.AddLineBreak();
      //      paragraph_ENTRETIEN_Content.Format.SpaceAfter = 20;

      //      paragraph_ENTRETIEN_Content.AddText("Materiel & Mobilier logements");
      //      paragraph_ENTRETIEN_Content.AddLineBreak();
      //      paragraph_ENTRETIEN_Content.Format.SpaceAfter = 20;

           
            

             

      //      Section sec = document.AddSection();
      //      Paragraph para = sec.AddParagraph();
      //      para.Format.Alignment = ParagraphAlignment.Left;
      //      para.Format.Font.Name = "Times New Roman";
      //      para.Format.Font.Size = 12;
      //      para.Format.Font.Color = Colors.DarkGray;  
      //      para.AddText(" \nMateriel / Mobilier de Bureau\n");
      //      para.AddText(" \nMateriel / Mobilier de logements\n");
      //      para.AddText(" \nAgencements Installation Banque\n");
      //      para.AddText(" \nMateriel Informatique / Telephonique\n");
      //      para.AddText(" \nLogiciel Informatique\n");
      //      para.AddText(" \nServices Informatique / Telephonique\n");
      //      para.Format.Alignment = ParagraphAlignment.Left;

      //      para.AddText(" \nServices Informatique / Telephonique\n");
      //      para.AddLineBreak();
      //      para.Format.Borders.DistanceFromLeft = "100pt";
      //      para.Format.Borders.Distance = "10pt";
      //      para.Format.Borders.Color = Colors.Gold;
      //      DocumentRenderer docRenderer = new DocumentRenderer(document);
      //      docRenderer.PrepareDocument();



      //      // ------------ AND ENTRETIEN

      //      /*
      //       Request for purchase of equipment or execution of work RequestPurchaseOrExecutionWork

      //       Demande d'achat de Materiel ou d'execusion de travaux
      //       Description Materiel ou traveaux a executer: [Tasse a cafe et Cuilleres]
      //       Motifs Invoques:[Ancien Unitilisables]

      //       Nature de la Demande
      //       Achat
      //           Materiel / Mobilier de Bureau
      //           Materiel / Mobilier de logements
      //           Agencements Installation Banque
      //           Materiel Informatique / Telephonique
      //           Logiciel Informatique
      //           Services Informatique /Telephonique
      //       Entretien
      //           Banque
      //           logements
      //           Vehicules
      //           Materiel et Mobilier Banque
      //           Materiel et Mobilier logements
      //       Service Generale
      //           Date d'achat/Construction
      //           Cout de l'operation
      //       Ligne budgetaire
      //           Budget primaire de l'annee
      //           Budget Modificatif de l'annee
      //           Entite d'imputation
      //           Hors Budget: Oui/Non
      //       Selection Fournisseur
      //           Information Fournisseur
      //           prix total
      //           Choix et Motifs


      //*/
      //      paragraph_Footer = section.Footers.Primary.AddParagraph();
      //      paragraph_Footer.AddText("Ecobank Business Services | N'Djamena Tchad");
      //      paragraph_Footer.Format.Alignment = ParagraphAlignment.Left;


      //      var pdfRender = new PdfDocumentRenderer();

      //      pdfRender.Document = document;

      //      pdfRender.RenderDocument();

      //      return pdfRender.PdfDocument;
      //  }

      //  private void BuilDocument(Document document)
      //  {
      //      //New section
      //      Section section = document.AddSection();             
      //      var paragraph = section.AddParagraph();
            

      //      paragraph.AddText("DEMANDE D'ACHAT DE MATERIEL OU D'EXECUSION DE TRAVEAUX");
      //      paragraph.AddLineBreak();
      //      paragraph.Format.SpaceAfter = 40;

      //      //New paragraph
      //      paragraph.AddText("DIRECTION GENERAL");
      //      paragraph.AddLineBreak();
      //      paragraph.AddText("ECOBANK BUSINESS SERVICES");
      //      paragraph.AddLineBreak();
      //      paragraph.AddText("ebsinfo@ecobank.com");
      //      paragraph.AddLineBreak();
      //      paragraph.AddText("Tel: 66 63 64 68");
      //      paragraph.Format.SpaceAfter = 20;


      //      string[,] products =
      //      {
      //          {"1","Aziz","2","100 000 Fcfa","200 0000 Fcfa" },
      //          {"1","Aziza","2","100 000 Fcfa","200 0000 Fcfa" },
      //          {"1","Azizou","2","100 000 Fcfa","200 0000 Fcfa" },
      //          {"1","Azizo","2","100 000 Fcfa","200 0000 Fcfa" },
      //      };
      //      var table = document.LastSection.AddTable();
      //      table.Borders.Width = 0.5;

      //      table.AddColumn("1Cm");
      //      table.AddColumn("9Cm");
      //      table.AddColumn("2Cm");
      //      table.AddColumn("2Cm");
      //      table.AddColumn("2Cm");

      //      Row row = table.AddRow();

      //      row.HeadingFormat = true;
      //      row.Format.Font.Bold = true;
      //      row.Cells[0].AddParagraph("No");
      //      row.Cells[1].AddParagraph("Items");
      //      row.Cells[2].AddParagraph("Quantity");
      //      row.Cells[3].AddParagraph("Unit Price");
      //      row.Cells[4].AddParagraph("TOTAL");

      //      for (int i = 0; i < products.GetLength(0); i++)
      //      {
      //          row = table.AddRow();
      //          row.Cells[0].AddParagraph(products[i, 0]);
      //          row.Cells[1].AddParagraph(products[i, 1]);
      //          row.Cells[2].AddParagraph(products[i, 2]);
      //          row.Cells[3].AddParagraph(products[i, 3]);
      //          row.Cells[4].AddParagraph(products[i, 4]);
      //      }

      //      paragraph = section.AddParagraph();
      //      paragraph.AddText("Subtotal: 800 000 Fcfa");
      //      paragraph.AddLineBreak();
      //      paragraph.AddText("Shipping Fee: 600 Fcfa");
      //      paragraph.AddLineBreak();
      //      paragraph.AddText("Total: 1 600 000");
      //      paragraph.AddLineBreak();
      //      paragraph.Format.SpaceAfter = 20;

      //      paragraph = section.Footers.Primary.AddParagraph();
      //      paragraph.AddText("Ecobank Business Services | N'Djamena Tchad");
      //      paragraph.Format.Alignment = ParagraphAlignment.Center;

      //  }

    }
}
