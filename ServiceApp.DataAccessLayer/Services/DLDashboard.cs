using Dapper;
using Microsoft.Data.SqlClient;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.Client.Utility;
using ServiceApp.Shared.Model.Chart;
using ServiceApp.Shared.Model.ModelRequest;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.DataAccessLayer.Services
{
    public class DLDashboard: DLBaseDataAccess, IDLDashboard
    {
        public IEnumerable<ChartModel> GetChartPercentage(Chart chart)
        {
            IEnumerable<ChartModel> chartModel = new List<ChartModel>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    IEnumerable<ChartModel> result = connection.Query<ChartModel>(
                         "pr_GetChartPercentage",
                         param: new { Timeline = chart.Timeline,
                                      Date1 = chart.Date1},
                         commandType: CommandType.StoredProcedure
                     );

                    chartModel = result;
                }
            }
            catch (Exception ex)
            {
                new MainServices { };
            }
            return chartModel;
        }
    }
}
