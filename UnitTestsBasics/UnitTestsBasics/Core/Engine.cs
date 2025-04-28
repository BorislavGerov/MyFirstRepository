using Company.Core.Interfaces;
using Company.Models;
using Company.Models.Companies;
using Company.Models.Companies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            ICompany company = new SofUniCompay();

            Employee firstEmployee = new Employee("Bobby", "C#", 22);
            company.AddEmployee(firstEmployee);
        }
    }
}
