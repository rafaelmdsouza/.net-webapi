using Companies.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class CompaniesController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var company = new Company 
            {  
                Id = id, 
                Name ="Test", 
                CNPJ = 0, 
                CNAE = 0, 
                MonthlyIncome = 0, 
                RegistrationDate = new DateTime() 
            };

            return Ok(company);
        }
    }
}
