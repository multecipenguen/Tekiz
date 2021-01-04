using Microsoft.AspNetCore.Authorization;
using Tekiz.Core.Permissions;

namespace Tekiz.Web.Core.Controllers
{
    [Authorize(Policy = DefaultPermissions.PermissionNameForMemberAccess)]
    public class AuthorizedController : BaseController
    {

    }
}