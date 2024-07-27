using ServiceApp.BusinessLayer.DomainServices.Services;
using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ServiceLayer.Services
{
    public class DashboardService : BaseDataAccessFactory, IDashboardService
    {
        private IGetChartPercentage chartPercentage;
        public DashboardService()
        {
            this.chartPercentage = new GetChartPercentage(this.dataAcesses);
        }
        public IEnumerable<ChartModel> GetChartPercentage(Chart chart)
        {
            return this.chartPercentage.Get(chart);
        }
    }
}
