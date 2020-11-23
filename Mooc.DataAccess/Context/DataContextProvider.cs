using Mooc.DataAccess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc.DataAccess.Context
{
   public class DataContextProvider : IDataContextProvider, IDependency
    {

        public DataContextProvider(DataContext dataContext)
        {

        }
        public DataContext GetDataContext()
        {
            return null;
        }
    }
}
