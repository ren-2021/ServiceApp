using Microsoft.AspNetCore.Mvc;
using ServiceApp.ServiceLayer.Services;
using ServiceApp.Shared.Model.Chart;
using ServiceApp.Shared.Model.ModelRequest;

namespace ServiceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : Controller
    {
        IDashboardService dashboardService;

        public DashboardController(IDashboardService _dashboardService)
        {

            this.dashboardService = _dashboardService;
        }

        [HttpGet("GetChartPercentage/{_timeline}")]
        public IEnumerable<ChartModel> GetChartPercentage(int _timeline)
        {
            return this.dashboardService.GetChartPercentage(_timeline);
        }
    }
}
