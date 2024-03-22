using ServiceApp.Shared.Model.Chart;
using ServiceApp.Shared.Model.ModelRequest;

namespace ServiceApp.Client.Services
{
    public interface IChartService
    {
        public Task<IEnumerable<ChartModel>> GetChartPercentage(int _timeline);
    }
}
