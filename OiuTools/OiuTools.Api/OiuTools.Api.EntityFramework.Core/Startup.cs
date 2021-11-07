using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace OiuTools.Api.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "OiuTools.Api.Database.Migrations");
        }
    }
}