using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class GetChartPercentage : BaseGetPercentage, IGetChartPercentage
    {
        public GetChartPercentage(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {

        }
        public IEnumerable<ChartModel> Get(int _timeline)
        {
            return this.DLDashboard.GetChartPercentage(_timeline);
        }
    }
}
