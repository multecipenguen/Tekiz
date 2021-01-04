using Tekiz.Application.Dto;

namespace Tekiz.Application.Users.Dto
{
    public class UserListOutput : PagedListOutput
    {
        public string UserName { get; set; }

        public string Email { get; set; }
    }
}