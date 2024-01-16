using ServiceApp.Shared.Model.Services.VISAProcessing.SubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model.Services.VISAProcessing
{
    public class VISAProcessing : IVISAProcessing
    {
        public readonly IUSA usa;   
        public readonly ICanadaETA canadaETA;    
        public readonly ICanadaRegular canadaRegular;
        public readonly INewZealand newZealand;     
        public readonly IChina china;     
        public readonly IJapan japan;      
        public readonly IAustralia australia;   
        public readonly IEuropeanCountries europeanCountries;   
        public readonly ISouthKorea southKorea;
        public IUSA USA => usa;
        public ICanadaETA CanadaETA => canadaETA;
        public ICanadaRegular CanadaRegular => canadaRegular;
        public INewZealand NewZealand => newZealand;
        public IChina China => china;
        public IJapan Japan => japan;
        public IAustralia Australia => australia;
        public IEuropeanCountries EuropeanCountries => europeanCountries;
        public ISouthKorea SouthKorea => southKorea;
        public bool IsIncluded { get; set; }

        public VISAProcessing(IUSA usa, ICanadaETA canadaETA, ICanadaRegular canadaRegular, INewZealand newZealand, IChina china, IJapan japan, IAustralia australia, IEuropeanCountries europeanCountries, ISouthKorea southKorea)
        {
            this.usa = usa;
            this.canadaETA = canadaETA;
            this.canadaRegular = canadaRegular;
            this.newZealand = newZealand;
            this.china = china;
            this.japan = japan;
            this.australia = australia;
            this.europeanCountries = europeanCountries;
            this.southKorea = southKorea;
        }
    }
}
