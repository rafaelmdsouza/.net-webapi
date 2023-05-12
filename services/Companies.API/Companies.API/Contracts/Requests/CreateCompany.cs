using Companies.API.Contracts.Response;

namespace Companies.API.Contracts.Requests
{
    public class CreateCompany
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
