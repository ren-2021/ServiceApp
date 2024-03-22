using ServiceApp.Shared.Model.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.Model
{
    public interface IDLDashboard
    {
        IEnumerable<ChartModel> GetChartPercentage(int _timeline);
    }
}
