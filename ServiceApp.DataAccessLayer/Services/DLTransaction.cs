﻿using Microsoft.Data.SqlClient;
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
        public bool AddTrasaction(string sample)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {

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