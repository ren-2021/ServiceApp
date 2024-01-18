﻿using Microsoft.Extensions.Configuration;
using ServiceApp.BusinessLayer.Model;
using ServiceApp.DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public class BasePrintTransaction : BaseDataAccess
    {
        private string template;
        public IConfiguration Configuration = new ConfigurationBuilder()
                                            .SetBasePath(Directory.GetCurrentDirectory())
                                            .AddJsonFile("appsettings.json").Build();
        public string Template{ get{ return template; } }
        public IDLPrint DLPrint { get { return this.dlBaseService.DLPrint; } }

        public BasePrintTransaction(List<IDataAccess> pDataAccess) : base(pDataAccess)
        {
            template = Configuration["Priting:Template"].ToString();
        }
        public BasePrintTransaction()
        {

        }
    }
}