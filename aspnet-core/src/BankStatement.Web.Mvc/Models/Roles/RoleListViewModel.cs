using System.Collections.Generic;
using BankStatement.Roles.Dto;

namespace BankStatement.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
