using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Aggregates.Company
{
    public class Employee
    {
        private Employee(){}

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public EmployeeType EmployeeType { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string CurrentCity { get; private set; }

        public static Employee CreateEmployee(string firstName, string lastName, EmployeeType employeeType, string email, string phone, DateTime dateOfBirth, string currentCity)
        {
            return new Employee()
            {
                FirstName = firstName,
                LastName = lastName,
                EmployeeType = employeeType,
                Email = email,
                Phone = phone,
                DateOfBirth = dateOfBirth,
                CurrentCity = currentCity
            };
        }
    }
}
