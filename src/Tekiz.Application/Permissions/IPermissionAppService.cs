using System.Collections.Generic;
using System.Threading.Tasks;
using Tekiz.Application.Permissions.Dto;
using Tekiz.Core.Permissions;

namespace Tekiz.Application.Permissions
{
    public interface IPermissionAppService
    {
        Task<IEnumerable<PermissionDto>> GetGrantedPermissionsAsync(string userNameOrEmail);

        Task<bool> IsUserGrantedToPermissionAsync(string userNameOrEmail, string permissionName);

        void InitializePermissions(List<Permission> permissions);
    }
}