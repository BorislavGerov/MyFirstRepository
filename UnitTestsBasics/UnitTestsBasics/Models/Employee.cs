using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Employee
    {
        public Employee(string name, string programmingLanguage, int age)
        {
            Name = name;
            ProgrammingLanguage = programmingLanguage;
            Age = age;
        }

        public string Name { get; private set; }

        public string ProgrammingLanguage{ get; private set; }

        public int Age { get; private set; }
    }
}
