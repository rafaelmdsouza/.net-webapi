namespace Companies.API.Registers
{
    public class SwaggerWebAppRegister : IWebApplicationRegisters
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
