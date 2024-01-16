using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.LTO.SubService
{
    public interface IRegistration
    {
        public bool IsIncluded { get; set; }
        public decimal Fee {  get; set; }
    }
}
