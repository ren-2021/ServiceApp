using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApp.Shared.Model;

namespace ServiceApp.DataAccessLayer.Services
{
    public class DLTransaction : DLBaseDataAccess, IDLTransaction
    {
        public bool AddTrasaction(string jsonString)
        {
            bool IsSuccess = false;
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    var parameters = new DynamicParameters();
                    parameters.Add("@JsonString", jsonString);
                    parameters.Add("@IsSuccess", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    connection.Execute("pr_ProcessTransaction", parameters, commandType: CommandType.StoredProcedure);

                    IsSuccess = parameters.Get<bool>("@IsSuccess");
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return IsSuccess;
        }

        public List<TransactionInfo> GetTrasactions()
        {
            List<TransactionInfo> result = new List<TransactionInfo>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    result = connection.Query<TransactionInfo>("pr_GetTransactions", commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public List<TransactionInfo> GetTransactionDate(DateOnly Start, DateOnly End)
        {
            List<TransactionInfo> result = new List<TransactionInfo>();
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    var parameters = new DynamicParameters();
                    parameters.Add("@FromDate", Start);
                    parameters.Add("@ToDate", End);
                    result = connection.Query<TransactionInfo>("pr_GetTransactions", commandType: CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
