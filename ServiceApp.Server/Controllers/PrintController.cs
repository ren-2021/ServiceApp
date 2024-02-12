using Microsoft.AspNetCore.Mvc;
using ServiceApp.ServiceLayer.Services;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;

namespace ServiceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintController : Controller
    {
        private IPrintService printService;

        public PrintController(IPrintService _printService)
        {

            this.printService = _printService;
        }

        [HttpGet("Generate/{_transactionID}")]
        public IActionResult Generate(int _transactionID)
        {
            var fileByte = this.printService.Print(_transactionID);
            return File(fileByte, "application/pdf", "sample1.pdf");
        }

        [HttpGet("GetServiceInfo/{_transactionID}")]
        public IEnumerable<PrintModel> GetServiceInfo(int _transactionID)
        {
            return this.printService.GetServicesInfo(_transactionID);
        }
    }
}
