using ServiceApp.Shared.Model.Services.LTO.SubService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.LTO
{
    public interface ILTO
    {
        public IRegistration Registration { get; set; }
        public bool IsIncluded { get; set; }
    }
}
