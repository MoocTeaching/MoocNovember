using AutoMapper;
using Mooc.DataAccess.Entities;
using Mooc.Models.Dtos.User;

namespace Mooc.DataAccess.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //CreateMap<User, UserDto>().ForMember(c => c.Email111, p => p.MapFrom(x => x.Email));
            CreateMap<User, UserDto>();
            CreateMap<CreateOrUpdateUserDto, User>();
        }
    }
}
