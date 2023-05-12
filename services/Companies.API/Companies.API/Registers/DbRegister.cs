using Companies.Infra;
using Microsoft.EntityFrameworkCore;

namespace Companies.API.Registers
{
    public class DbRegister : IWebApplicationBuilderRegisters
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
