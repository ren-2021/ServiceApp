using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.DataAccessLayer
{
    public class DLBaseDataAccess
    {
        public DbContextOptionsBuilder<BaseDbContext> Builder = new DbContextOptionsBuilder<BaseDbContext>();

        private string connectionString;

        public IConfiguration Configuration = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json").Build();
        public string ConnectionString 
        {
            get
            {
                return connectionString;
            }
        }

        public DLBaseDataAccess()
        {
            connectionString = Configuration["ConnectionStrings:DefaultConnection"].ToString();
           //Builder.UseSqlServer(Configuration["ConnectionStrings:OneSysDB"]);
        }
    }
}
