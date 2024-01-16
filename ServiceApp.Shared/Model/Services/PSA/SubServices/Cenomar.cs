﻿using ServiceApp.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.PSA.SubServices
{
    public class Cenomar : ICenomar
    {
        public bool IsIncluded { get; set; }
        public decimal Fee { get; set; }
    }
}
