using Mooc.Models.Dtos.User;
using System.Collections.Generic;

namespace Mooc.DataAccess.Service
{
    public interface IUserService : IDependency
    {
        bool Add(CreateOrUpdateUserDto  createOrUpdateUserDto);

        List<UserDto> GetList();
    }
}
