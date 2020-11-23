using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc.DataAccess.Context
{
   public interface IDataContextProvider
    {
        DataContext GetDataContext();
    }
}
