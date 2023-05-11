namespace Companies.API.Registers
{
    public interface IWebApplicationBuilderRegisters : IRegister
    {
        public void RegisterServices(WebApplicationBuilder builder);
    }
}
