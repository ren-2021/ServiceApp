using Microsoft.AspNetCore.Mvc;

namespace ServiceApp.Server.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
