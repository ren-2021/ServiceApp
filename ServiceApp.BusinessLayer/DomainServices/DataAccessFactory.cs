using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApp.BusinessLayer.Model;

namespace ServiceApp.BusinessLayer.DomainServices
{
    public class DataAccessFactory : IDataAcessFactory
    {

        public List<IDataAccess> DataAccess { get; set; }


        public DataAccessFactory(List<IDataAccess> pDataAccess)
        {
            DataAccess = pDataAccess;
        }

        public T GetDL<T>()
        {
            T Value = default;

            try
            {
                foreach (IDataAccess DL in DataAccess)
                {
                    Type tDL = DL.GetType();
                    Type[] ArrInterfaces = tDL.GetInterfaces();

                    foreach (Type iT in ArrInterfaces)
                    {
                        if (iT.Name == typeof(T).Name)
                        {
                            Value = (T)DL;
                            break;
                        }
                    }

                    if (Value != null)
                    {
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }



            return Value;
        }
    }
}
