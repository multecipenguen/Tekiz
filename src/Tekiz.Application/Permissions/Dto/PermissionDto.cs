using Tekiz.Application.Dto;

namespace Tekiz.Application.Permissions.Dto
{
    public class PermissionDto : EntityDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }
    }
}