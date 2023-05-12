using Companies.API.Application.Commands.CompanyCommands;
using Companies.Domain.Aggregates.Company;
using Companies.Infra;
using MediatR;

namespace Companies.API.Application.CommandHandlers.CompanyHandler
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly DataContext _context;
        public CreateEmployeeHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee(request.FirstName, request.LastName,request.EmployeeType,request.Email, request.Phone, request.DateOfBirth, request.CurrentCity);

            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();

            return employee;
        }
    }
}
