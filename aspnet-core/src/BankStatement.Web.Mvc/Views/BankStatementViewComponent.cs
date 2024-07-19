using Abp.AspNetCore.Mvc.ViewComponents;

namespace BankStatement.Web.Views
{
    public abstract class BankStatementViewComponent : AbpViewComponent
    {
        protected BankStatementViewComponent()
        {
            LocalizationSourceName = BankStatementConsts.LocalizationSourceName;
        }
    }
}
