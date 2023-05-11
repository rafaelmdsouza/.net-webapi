namespace Companies.API.Registers
{
    public class SwaggerRegister : IWebApplicationBuilderRegisters
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
        }
    }
}
