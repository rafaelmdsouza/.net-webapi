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

        public Company(string name, Employee employee, int cnpj, int cnae, double monthlyIncome, DateTime registrationDate, DateTime lastModified)
        {
            Name = name;
            Employee = employee;
            CNPJ = cnpj;
            CNAE = cnae;
            MonthlyIncome = monthlyIncome;
            RegistrationDate = registrationDate;
            LastModified = lastModified;

            _history.Add(new CompanyHistory("Admin", "Employee Created", null));
        }

        public string Name { get; private set; }
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

            _history.Add(new CompanyHistory(UpdatedBy, "Employee Updated", null));
        }

    }
}
