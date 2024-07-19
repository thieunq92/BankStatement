using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BankStatement.Controllers
{
    public abstract class BankStatementControllerBase: AbpController
    {
        protected BankStatementControllerBase()
        {
            LocalizationSourceName = BankStatementConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
