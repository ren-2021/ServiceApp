using Microsoft.AspNetCore.Mvc;
using ServiceApp.ServiceLayer.Services;
using ServiceApp.Shared.Model;

namespace ServiceApp.Server.Controllers
{
    public class PrintController : Controller
    {
        private IPrintService printService;

        [HttpGet("GetTransaction")]
        public ActionResult<PrintingInfo> Generate()
        {
            return this.printService.Print();
        }
    }
}
