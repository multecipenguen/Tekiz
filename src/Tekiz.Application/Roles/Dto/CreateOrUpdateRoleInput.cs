﻿using System;
using System.Collections.Generic;

namespace Tekiz.Application.Roles.Dto
{
    public class CreateOrUpdateRoleInput
    {
        public RoleDto Role { get; set; } = new RoleDto();

        public List<Guid> GrantedPermissionIds { get; set; } = new List<Guid>();
    }
}
