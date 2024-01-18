using ServiceApp.Shared.Model.Services.Financial.SubServices;
using ServiceApp.Shared.Model.Services.LTO.SubService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.LTO
{
    public class LTO : ILTO
    {
        private readonly Registration registration;
        public bool IsIncluded { get; set; }
        public Registration Registration { get => registration; set { } }

        public LTO(Registration registration)
        {
            this.registration = registration;
        }
    }
}
