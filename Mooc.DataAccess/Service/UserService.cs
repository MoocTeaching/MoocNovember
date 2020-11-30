using AutoMapper;
using Mooc.DataAccess.Context;
using Mooc.DataAccess.Entities;
using Mooc.Models.Dtos.User;
using System.Collections.Generic;
using System.Linq;

namespace Mooc.DataAccess.Service
{
    public class UserService : IUserService
    {
        private DataContext _db;
        //private IMapper _mapper;
        public UserService(IDataContextProvider  dataContextProvider)
        {
            this._db = dataContextProvider.GetDataContext();
            //this._mapper = mapper;
        }

        public bool Add(CreateOrUpdateUserDto  createOrUpdateUserDto)
        {
            var user = Mapper.Map<User>(createOrUpdateUserDto);
            this._db.Users.Add(user);
            return this._db.SaveChanges() > 0;
        }

        public List<UserDto> GetList()
        {
            var list = _db.Users.ToList();
            return Mapper.Map<List<UserDto>>(list);
        }

    }
}
