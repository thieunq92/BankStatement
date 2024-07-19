using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BankStatement.Authorization.Roles;
using BankStatement.Authorization.Users;
using BankStatement.MultiTenancy;

namespace BankStatement.EntityFrameworkCore
{
    public class BankStatementDbContext : AbpZeroDbContext<Tenant, Role, User, BankStatementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BankStatementDbContext(DbContextOptions<BankStatementDbContext> options)
            : base(options)
        {
        }
    }
}
