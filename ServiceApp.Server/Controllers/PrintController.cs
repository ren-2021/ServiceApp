using Microsoft.AspNetCore.Mvc;
using ServiceApp.ServiceLayer.Services;
using ServiceApp.Shared.Model;

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

        [HttpPost("Generate")]
        public ActionResult<PrintingInfo> Generate()
        {
            return this.printService.Print();
        }
    }
}
