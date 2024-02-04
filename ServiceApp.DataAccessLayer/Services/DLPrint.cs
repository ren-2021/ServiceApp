using Dapper;
using Microsoft.Data.SqlClient;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkiaSharp.HarfBuzz.SKShaper;

namespace ServiceApp.DataAccessLayer.Services
{
    public class DLPrint : DLBaseDataAccess, IDLPrint
    {
        public TransactionInfo GetTransactionInfoByID(int _transactionID)
        {
            TransactionInfo result = new TransactionInfo();
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    result = connection.QueryFirst<TransactionInfo>("pr_GetTransactionByID",
                         param: new { transactionID = _transactionID }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public IEnumerable<PrintModel> GetTransactionServicesInfo(int _transactionID)
        {
            IEnumerable<PrintModel> services = new List<PrintModel>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    IEnumerable<PrintModel> result = connection.Query<PrintModel>(
                         "pr_getSubServicesInfo",
                         param: new { transactionID = _transactionID },
                         commandType: CommandType.StoredProcedure
                     );

                    services = result;
                }
            }
            catch (Exception ex)
            {
                new MainServices { };
            }
            return services;
        }
    }
}
