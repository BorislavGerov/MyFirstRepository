using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAtribute : Attribute
    {
        public AuthorAtribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
