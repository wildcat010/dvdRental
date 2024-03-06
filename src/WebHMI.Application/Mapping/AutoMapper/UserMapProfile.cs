using AutoMapper;
using WebHMI.Dtos.Users;
using WebHMI.WebHMI.Dbo;

namespace WebHMI.Mapping.AutoMapper
{
	public class UserMapProfile : Profile
	{
		public UserMapProfile()
		{
			CreateMap<UserDto, User>();
			CreateMap<UserDto, User>()
				.ForMember(x => x.Roles, opt => opt.Ignore())
				.ForMember(x => x.CreationTime, opt => opt.Ignore());

			CreateMap<CreateUserDto, User>();
			CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
		}
	}
}


