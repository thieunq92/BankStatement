using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BankStatement.Authorization;

namespace BankStatement
{
    [DependsOn(
        typeof(BankStatementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BankStatementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BankStatementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BankStatementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
