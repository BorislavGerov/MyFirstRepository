using Company.Models;
using Company.Models.Companies;
using Company.Models.Companies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Tests
{
    public class CompanyTests
    {
        private SofUniCompay company;
        private Employee employee;

        [SetUp]
        public void SetUp()
        {
            company = new SofUniCompay();
            employee = new Employee("Bobby", "C#", 22);
        }

        [Test]
        public void AddEmployeeMethod_ShouldAddEmplyee_Correctly()
        {
            company.AddEmployee(employee);
            Assert.AreEqual(true, company.Employees.Contains(employee));
        }
    }
}
