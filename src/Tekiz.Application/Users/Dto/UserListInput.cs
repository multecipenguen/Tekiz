using Tekiz.Application.Dto;

namespace Tekiz.Application.Users.Dto
{
    public class UserListInput : PagedListInput
    {
        public UserListInput()
        {
            SortBy = "UserName";
        }
    }
}