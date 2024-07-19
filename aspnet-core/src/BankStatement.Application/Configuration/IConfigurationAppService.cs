using System.Threading.Tasks;
using BankStatement.Configuration.Dto;

namespace BankStatement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
