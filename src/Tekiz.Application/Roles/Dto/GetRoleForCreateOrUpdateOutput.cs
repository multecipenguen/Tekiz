using System;
using System.Collections.Generic;
using Tekiz.Application.Permissions.Dto;

namespace Tekiz.Application.Roles.Dto
{
    public class GetRoleForCreateOrUpdateOutput
    {
        public RoleDto Role { get; set; } = new RoleDto();

        public List<PermissionDto> AllPermissions { get; set; } = new List<PermissionDto>();

        public List<Guid> GrantedPermissionIds { get; set; } = new List<Guid>();
    }
}