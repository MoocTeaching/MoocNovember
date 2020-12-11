using AutoMapper;
using Mooc.DataAccess.Dtos.User;
using Mooc.DataAccess.Entities;


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