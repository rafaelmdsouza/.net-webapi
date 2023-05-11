namespace Companies.API.Registers
{
    public interface IWebApplicationRegisters : IRegister
    {
        public void RegisterPipelineComponents(WebApplication app);

    }
}
