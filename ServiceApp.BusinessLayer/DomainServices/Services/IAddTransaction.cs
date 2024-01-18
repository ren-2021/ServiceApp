using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.BusinessLayer.DomainServices.Services
{
    public interface IAddTransaction
    {
        bool Add(string sample);
    }
}
