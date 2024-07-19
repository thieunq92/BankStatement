using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace BankStatement.Web.Views
{
    public abstract class BankStatementRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BankStatementRazorPage()
        {
            LocalizationSourceName = BankStatementConsts.LocalizationSourceName;
        }
    }
}
