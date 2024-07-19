using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BankStatement.MultiTenancy;

namespace BankStatement.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
