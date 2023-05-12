using AutoMapper;
using Companies.API.Application.Commands.CompanyCommands;
using Companies.API.Contracts.Requests;
using Companies.API.Contracts.Response;
using Companies.Domain.Aggregates.Company;

namespace Companies.API.MappingProfiles
{
    public class EmployeeMappings : Profile
    {
        public EmployeeMappings()
        {
            CreateMap<CreateEmployee, CreateEmployeeCommand>();
            CreateMap<Employee, EmployeeResponse>();
        }
    }
}
