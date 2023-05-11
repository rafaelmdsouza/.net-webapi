namespace Companies.API.Registers
{
    public class MvcRegister : IWebApplicationBuilderRegisters
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
