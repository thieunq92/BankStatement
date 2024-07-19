using System.Threading.Tasks;
using Abp.Application.Services;
using BankStatement.Sessions.Dto;

namespace BankStatement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
