using AutoMapper;
using Mooc.DataAccess.Context;
using Mooc.DataAccess.Entities;
using Mooc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Add(UserViewModel userViewModel)
        {
            var user = Mapper.Map<User>(userViewModel);
            this._db.Users.Add(user);
            return this._db.SaveChanges() > 0;
        }

        public List<UserViewModel> GetList()
        {
            var list = _db.Users.ToList();
            return Mapper.Map<List<UserViewModel>>(list);
        }
    }
}
