using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BankStatement.EntityFrameworkCore;
using BankStatement.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BankStatement.Web.Tests
{
    [DependsOn(
        typeof(BankStatementWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BankStatementWebTestModule : AbpModule
    {
        public BankStatementWebTestModule(BankStatementEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BankStatementWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BankStatementWebMvcModule).Assembly);
        }
    }
}