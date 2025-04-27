using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationAttribute.Core.Interfaces;
using ValidationAttribute.Attributes;

namespace ValidationAttribute
{
    public class Engine : IEngine
    {
        public void Run()
        {
            Person person = new Person(null, 13);
            bool isValid = Attributes.Validator.IsValid(person);
            Console.WriteLine(isValid);
        }
    }
}
