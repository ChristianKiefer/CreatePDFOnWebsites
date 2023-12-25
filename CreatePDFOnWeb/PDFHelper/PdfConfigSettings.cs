using DinkToPdf;

namespace CreatePDFOnWeb.PDFHelper
{
    public class PdfConfigSettings
    {
        public static HtmlToPdfDocument GetHtmlToPdfDocument()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "",
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = "",  // hier wird später der HTML-Code eingefügt
                WebSettings = { 
                    DefaultEncoding = "utf-8", 
                    EnableJavascript = false, 
                    UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(),
                                                  "wwwroot/css", "PDFstyles.css") 
                },
                FooterSettings = { 
                    FontName = "Calibri, Arial", 
                    FontSize = 8, 
                    Right = "Seite [page] von [toPage]", 
                    Line = false }
            };

            var htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            return htmlToPdfDocument;
        }
    }
}
