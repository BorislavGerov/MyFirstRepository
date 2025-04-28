using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models.Companies.Interfaces
{
    public interface ICompany
    {
        public void AddEmployee(Employee employee);

        public void RemoveEmployee(Employee employee);
    }
}
