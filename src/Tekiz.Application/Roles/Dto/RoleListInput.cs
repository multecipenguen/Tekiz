using Tekiz.Application.Dto;

namespace Tekiz.Application.Roles.Dto
{
    public class RoleListInput : PagedListInput
    {
        public RoleListInput()
        {
            SortBy = "Name";
        }
    }
}