using ServiceApp.Shared.Model.Services.VISAProcessing.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.VISAProcessing
{
    public interface IVISAProcessing
    {
        public IUSA USA { get; }
        public ICanadaETA CanadaETA { get; }
        public ICanadaRegular CanadaRegular { get; }    
        public INewZealand NewZealand { get; }
        public IChina China { get; }
        public IJapan Japan { get; }
        public IAustralia Australia { get; }
        public IEuropeanCountries EuropeanCountries { get; }
        public ISouthKorea SouthKorea { get; }
        public bool IsIncluded { get; set; }
    }
}
