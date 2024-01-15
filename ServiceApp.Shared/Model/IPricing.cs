using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Shared.Model
{
    public interface IPricing
    {
        public decimal Fee { get; set; }
    }
}
