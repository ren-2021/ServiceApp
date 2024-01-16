using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.VISAProcessing.SubServices
{
    public interface IEuropeanCountries
    {
        public bool IsIncluded { get; set; }
        public decimal Fee { get; set; }
    }
}
