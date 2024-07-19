using Abp.Authorization;
using BankStatement.Authorization.Roles;
using BankStatement.Authorization.Users;

namespace BankStatement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
