using Companies.Domain.Aggregates.Company;
using MediatR;

namespace Companies.API.Application.Commands.CompanyCommands
{
    public class CreateEmployeeCommand : IRequest<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CurrentCity { get; set; }
    }
}
