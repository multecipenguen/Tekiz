using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tekiz.Application.Permissions;
using Tekiz.Application.Permissions.Dto;
using Tekiz.Web.Core.Controllers;

namespace Tekiz.Web.Api.Controller.Permissions
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : AuthorizedController
    {
        private readonly IPermissionAppService _permissionAppService;

        public PermissionsController(IPermissionAppService permissionAppService)
        {
            _permissionAppService = permissionAppService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PermissionDto>>> GetPermissions(string userNameOrEmail)
        {
            return Ok(await _permissionAppService.GetGrantedPermissionsAsync(userNameOrEmail));
        }
    }
}