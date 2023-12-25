using CreatePDFOnWeb.PDFHelper;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CreatePDFOnWeb.Controllers
{
    public class PdfController : Controller
    {
        private readonly IConverter _converter; 

        public PdfController(IConverter converter)
        {
            _converter = converter;
        }

        public IActionResult ShowPDF()
        {
            HtmlToPdfDocument htmlToPdfDocument = PdfConfigSettings.GetHtmlToPdfDocument();
            htmlToPdfDocument.Objects[0].HtmlContent = PdfReportGenerator.GetHTMLString();
            byte[] file = _converter.Convert(htmlToPdfDocument);

            return File(file, "application/pdf");
        }
    }
}
