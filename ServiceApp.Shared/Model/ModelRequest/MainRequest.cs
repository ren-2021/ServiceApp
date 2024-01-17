using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.ModelRequest
{
    public class MainRequest
    {
        public ClientInfo? ClientInfo { get; set; }

        public MainServices? MainServices { get; set; }
    }
}
