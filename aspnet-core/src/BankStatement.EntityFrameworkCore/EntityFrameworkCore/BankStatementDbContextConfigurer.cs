using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BankStatement.EntityFrameworkCore
{
    public static class BankStatementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BankStatementDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BankStatementDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
