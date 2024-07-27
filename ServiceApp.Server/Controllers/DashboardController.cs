using Microsoft.AspNetCore.Mvc;
using ServiceApp.Client.Utility;
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

        [HttpGet("GetChartPercentage/{chart}")]
        public IEnumerable<ChartModel> GetChartPercentage(Chart chart)
        {
            return this.dashboardService.GetChartPercentage(chart);
        }
    }
}
