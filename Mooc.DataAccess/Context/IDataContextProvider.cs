using Mooc.Services.Interfaces;

namespace Mooc.DataAccess.Context
{
    public interface IDataContextProvider : IDependency
    {
        DataContext GetDataContext();
    }
}
