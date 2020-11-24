using Mooc.DataAccess.Entities;
using Mooc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc.DataAccess.Service
{
    public interface IUserService : IDependency
    {
        bool Add(UserViewModel userViewModel);
        List<UserViewModel> GetList();
    }
}
