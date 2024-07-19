using Abp.Application.Services;
using BankStatement.MultiTenancy.Dto;

namespace BankStatement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

