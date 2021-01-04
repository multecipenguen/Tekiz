﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tekiz.Application.Dto;
using Tekiz.Application.Roles;
using Tekiz.Application.Roles.Dto;
using Tekiz.Core.Permissions;
using Tekiz.Utilities.Collections;
using Tekiz.Web.Core.Controllers;

namespace Tekiz.Web.Api.Controller.Roles
{
    public class RolesController : AdminController
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        [HttpGet]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleRead)]
        public async Task<ActionResult<IPagedList<RoleListOutput>>> GetRoles([FromQuery] RoleListInput input)
        {
            return Ok(await _roleAppService.GetRolesAsync(input));
        }

        [HttpGet("{id}")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleCreate)]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleUpdate)]
        public async Task<ActionResult<GetRoleForCreateOrUpdateOutput>> GetRoles(Guid id)
        {
            var getRoleForCreateOrUpdateOutput = await _roleAppService.GetRoleForCreateOrUpdateAsync(id);

            return Ok(getRoleForCreateOrUpdateOutput);
        }

        [HttpPost]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleCreate)]
        public async Task<ActionResult> PostRoles([FromBody] CreateOrUpdateRoleInput input)
        {
            var identityResult = await _roleAppService.AddRoleAsync(input);

            if (identityResult.Succeeded)
            {
                return Created(Url.Action("PostRoles"), identityResult);
            }

            return BadRequest(identityResult.Errors.Select(e => new NameValueDto(e.Code, e.Description)));
        }

        [HttpPut]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleUpdate)]
        public async Task<ActionResult> PutRoles([FromBody] CreateOrUpdateRoleInput input)
        {
            var identityResult = await _roleAppService.EditRoleAsync(input);

            if (identityResult.Succeeded)
            {
                return Ok();
            }

            return BadRequest(identityResult.Errors.Select(e => new NameValueDto(e.Code, e.Description)));
        }

        [HttpDelete]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleDelete)]
        public async Task<ActionResult> DeleteRoles(Guid id)
        {
            var identityResult = await _roleAppService.RemoveRoleAsync(id);

            if (identityResult.Succeeded)
            {
                return NoContent();
            }

            return BadRequest(identityResult.Errors.Select(e => new NameValueDto(e.Code, e.Description)));
        }
    }
}