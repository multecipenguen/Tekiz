using AutoMapper;
using Tekiz.Application.Permissions.Dto;
using Tekiz.Application.Roles.Dto;
using Tekiz.Application.Users.Dto;
using Tekiz.Core.Permissions;
using Tekiz.Core.Roles;
using Tekiz.Core.Users;

namespace Tekiz.Application
{
    public class ApplicationServiceAutoMapperProfile : Profile
    {
        public ApplicationServiceAutoMapperProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(u => u.Password, opt => opt.Ignore());
            
            CreateMap<User, UserListOutput>();
            CreateMap<Permission, PermissionDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<Role, RoleListOutput>();
        }
    }
}