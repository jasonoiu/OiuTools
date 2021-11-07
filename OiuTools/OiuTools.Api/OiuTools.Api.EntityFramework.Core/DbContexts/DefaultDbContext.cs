using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace OiuTools.Api.EntityFramework.Core
{
    [AppDbContext("mysql", DbProvider.MySql)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
            InsertOrUpdateIgnoreNullValues = true;
        }
    }
}