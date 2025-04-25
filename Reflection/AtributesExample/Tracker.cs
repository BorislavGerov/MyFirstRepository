using AuthorProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtributesExample
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            StringBuilder sb = new StringBuilder();
            Type type = typeof(StartUp);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            foreach (MethodInfo method in methods)
            {
                if(method.CustomAttributes.Any(m => m.AttributeType == typeof(AuthorAtribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (var attribute in attributes)
                    {
                        sb.AppendLine($"{method.Name} is written by {attribute}");
                    }
                }
            }
        }
    }
}
