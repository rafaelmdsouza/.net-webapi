using Companies.Domain.Aggregates.Company;

namespace Companies.API.Contracts.Response
{
    public class CompanyResponse
    {
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public Guid EmployeeId { get; set; }
        public EmployeeResponse Employee { get; set; }
        public int CNPJ { get; set; }
        public int CNAE { get; set; }
        public double MonthlyIncome { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
