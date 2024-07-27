using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public interface IGetChartPercentage
    {
        IEnumerable<ChartModel> Get(Chart chart);
    }
}
