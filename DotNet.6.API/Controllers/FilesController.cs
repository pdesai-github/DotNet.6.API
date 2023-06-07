using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet._6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {

        [HttpGet("pdf")]
        public ActionResult GetPdf()
        {
            var filePath = "Files//MyFile.pdf";

            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/pdf", "file.pdf");
        }

        [HttpGet("excel")]
        public ActionResult GetExcel()
        {
            var filePath = "Files//MyFile.xlsx";
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "file.xlsx");
        }

        [HttpGet("word")]
        public ActionResult GetWord()
        {
            var filePath = "Files//MyFile.docx";
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "file.docx");
        }

        [HttpGet("csv")]
        public ActionResult GetCsv()
        {
            var filePath = "Files//MyFile.csv";
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/csv", "file.csv");
        }
    }
}
