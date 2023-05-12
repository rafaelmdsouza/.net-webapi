using Companies.API.Contracts.Response;
using Companies.Domain.Aggregates.Company;
using MediatR;

namespace Companies.API.Application.Commands.CompanyCommands
{
    public class CreateCompanyCommand: IRequest<Company>
    {
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public Guid EmployeeId { get; set; }
        public EmployeeResponse Employee { get; set; }
        public int CNPJ { get; set; }
        public int CNAE { get; set; }
        public double MonthlyIncome { get; set; }
    }
}
