using System.Collections.Generic;
using BankStatement.Roles.Dto;

namespace BankStatement.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
