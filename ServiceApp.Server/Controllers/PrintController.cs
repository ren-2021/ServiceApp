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

        [HttpPost("Generate/{_transactionID}")]
        public ActionResult<PrintingInfo> Generate(int _transactionID)
        {
            return this.printService.Print(_transactionID);
        }

        [HttpGet("GetServiceInfo/{_transactionID}")]
        public IEnumerable<PrintModel> GetServiceInfo(int _transactionID)
        {
            return this.printService.GetServicesInfo(_transactionID);
        }
    }
}
