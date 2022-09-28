using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestePdf.Interfaces;

namespace TestePdf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var pdfFile = _reportService.GeneratePdfReport(
                DateTime.Now.ToShortDateString(),
                "DAM 255 INFORMATICA LTDA",
                "27/09/2022",
                "27/09/2022"
            );
            MemoryStream ms = new MemoryStream(pdfFile);
            return new FileStreamResult(ms, "application/pdf");
        }
    }
}
