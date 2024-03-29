﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Tekiz.Core.Users
{
    public class User : IdentityUser<Guid>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}