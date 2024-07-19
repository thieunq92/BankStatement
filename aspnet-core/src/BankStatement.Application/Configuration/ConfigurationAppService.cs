using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BankStatement.Configuration.Dto;

namespace BankStatement.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BankStatementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
