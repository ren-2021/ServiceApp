using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.DataAccessLayer.Services
{
    public class DLTransaction : DLBaseDataAccess, IDLTransaction
    {
        public bool AddTrasaction(string jsonString)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    connection.Execute("pr_ProcessData",
                    new{ JsonString = jsonString },
                    commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
