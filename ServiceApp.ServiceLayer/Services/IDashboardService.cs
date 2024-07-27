using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceLayer.Services
{
    public interface IDashboardService
    {
        public IEnumerable<ChartModel> GetChartPercentage(Chart chart);
    }
}
