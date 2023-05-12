using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Aggregates.Company
{
    public class Company
    {
        private readonly List<CompanyHistory> _history = new List<CompanyHistory>();
        private Company()
        {
        }

        public Company(string name, Employee employee, int cnpj, int cnae, double monthlyIncome)
        {
            Name = name;
            Employee = employee;
            CNPJ = cnpj;
            CNAE = cnae;
            MonthlyIncome = monthlyIncome;
            RegistrationDate = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;

            _history.Add(new CompanyHistory(CompanyId,"Admin", "Employee Created", null));
        }
        public Guid CompanyId { get; private set; }
        public string Name { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Employee Employee { get; private set; }
        public int CNPJ { get; private set; }
        public int CNAE { get; private set; }
        public double MonthlyIncome { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<CompanyHistory> History { get => _history; }   

        public void UpdateEmployee(Employee newEmployee, string UpdatedBy)
        {
            Employee = newEmployee;
            LastModified = DateTime.UtcNow;

            _history.Add(new CompanyHistory(CompanyId, UpdatedBy, "Employee Updated", null));
        }

    }
}
