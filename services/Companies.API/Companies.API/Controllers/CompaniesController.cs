using AutoMapper;
using Companies.API.Application.Commands.CompanyCommands;
using Companies.API.Contracts.Requests;
using Companies.API.Contracts.Response;
using Companies.Domain.Aggregates.Company;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{

    [ApiController]
    [Route(ApiRoutes.BaseRoute)]
    public class CompaniesController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CompaniesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;  
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCompanies()
        {
            return await Task.FromResult(Ok()).ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] CreateCompany company)
        {
            return await Task.FromResult(Ok()).ConfigureAwait(false);
        }

        //[HttpPost]
        //[Route(ApiRoutes.Companies.CreateEmployee)]
        //public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployee employee)
        //{
        //    var command = _mapper.Map<CreateEmployeeCommand>(employee);
        //    var response = await _mediator.Send(command);
        //    var employeeResponse = _mapper.Map<EmployeeResponse>(response);

        //    return CreatedAtAction();
        //}

        [HttpGet]
        [Route(ApiRoutes.Companies.GetById)]
        public IActionResult GetById(int id)
        {
            var employee = new Employee("Rafael", "Moraes", EmployeeType.CEO, "email@email.com", "1919", DateTime.UtcNow, "vrasil");
            var company = new Company("Name", employee, 0, 0, 0);

            return Ok(company);
        }

    }
}
