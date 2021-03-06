﻿using Mooc.Models.Dtos.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mooc.Services.Interfaces
{
    public interface IUserService : IDependency
    {
        bool Add(CreateOrUpdateUserDto createOrUpdateUserDto);

        List<UserDto> GetList();

        Task<UserDto> GetUser(int id);

        Task<CreateOrUpdateUserDto> GetEditUser(int id);

        bool Update(CreateOrUpdateUserDto updateUser);

        bool Delete(CreateOrUpdateUserDto deleteUser);
        
        List<UserDto> GetLoginUser(string email,string pw);


    }
}
