using Companies.Domain.Aggregates.Company;

namespace Companies.API.Contracts.Response
{
    public class EmployeeResponse
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public EmployeeType EmployeeType { get;  set; }
        public string Email { get;  set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get;  set; }
        public string CurrentCity { get;  set; }
    }
}
