using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model.Chart;
using ServiceApp.Shared.Model.ModelRequest;

namespace ServiceApp.Client.Services
{
    public interface IChartService
    {
        public Task<IEnumerable<Chart>> GetChartPercentage(Chart chart);
    }
}
