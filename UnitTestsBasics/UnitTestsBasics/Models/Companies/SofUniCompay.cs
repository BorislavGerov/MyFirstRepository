using Company.Models.Companies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models.Companies
{
    public class SofUniCompay : ICompany
    {

        public SofUniCompay()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}
