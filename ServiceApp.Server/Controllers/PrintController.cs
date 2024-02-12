using Microsoft.AspNetCore.Mvc;
using ServiceApp.ServiceLayer.Services;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using System;

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
        public async Task<IActionResult> Generate(int _transactionID)
        {
            var memory = new MemoryStream();
            var file = this.printService.Print(_transactionID);
            using (var stream = new FileStream(file.FullPath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory,"application/pdf", Path.GetFileName(file.FullPath));
        }

        [HttpGet("GetServiceInfo/{_transactionID}")]
        public IEnumerable<PrintModel> GetServiceInfo(int _transactionID)
        {
            return this.printService.GetServicesInfo(_transactionID);
        }
    }
}
