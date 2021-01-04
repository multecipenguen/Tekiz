using Tekiz.Application.Dto;

namespace Tekiz.Application.Roles.Dto
{
    public class RoleListOutput : PagedListOutput
    {
        public string Name { get; set; }

        public bool IsSystemDefault { get; set; }
    }
}