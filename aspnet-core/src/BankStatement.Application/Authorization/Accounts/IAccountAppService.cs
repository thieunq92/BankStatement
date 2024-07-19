using System.Threading.Tasks;
using Abp.Application.Services;
using BankStatement.Authorization.Accounts.Dto;

namespace BankStatement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
