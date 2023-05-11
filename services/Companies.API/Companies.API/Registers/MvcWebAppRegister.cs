namespace Companies.API.Registers
{
    public class MvcWebAppRegister : IWebApplicationRegisters
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
