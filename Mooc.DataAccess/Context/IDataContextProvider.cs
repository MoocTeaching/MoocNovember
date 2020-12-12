using Mooc.Interface;

namespace Mooc.DataAccess.Context
{
    public interface IDataContextProvider : IDependency
    {
        DataContext GetDataContext();
    }
}
