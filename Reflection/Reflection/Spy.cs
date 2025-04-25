using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFiealdInfo(string className, string[] namesOfFields)
        {
            StringBuilder sb = new StringBuilder();
            Type classType = Type.GetType(className);
            FieldInfo[] fields = classType.GetFields((BindingFlags)60);
            Object classInstance = Activator.CreateInstance(classType);
            sb.AppendLine($"Class under invastigation: {classType.Name}");
            foreach (FieldInfo field in fields.Where(f => namesOfFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} - {field.GetValue(classInstance)}");
            }

            return sb.ToString();
        }

        public string AnalyzeAccesModifiers(string className)
        {
            Type type = Type.GetType(className);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            MethodInfo[] classPublicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] classPrivateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();
            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo privateMethod in classPrivateMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{privateMethod.Name} must be public!");
            }

            foreach (MethodInfo publicMethod in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{publicMethod.Name} must be private!");
            }

            return sb.ToString();
        }

        public string RevealPrivateMethods(string className)
        {
            Type type = Type.GetType(className);
            MemberInfo[] privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class name: {type.FullName}");
            sb.AppendLine($"Base class {type.BaseType.Name}");
            foreach (MethodInfo privateMethod in privateMethods)
            {
                sb.AppendLine(privateMethod.Name);
            }
            return sb.ToString();
        }

        public string GettersAndSetters(string className)
        {
            Type type = Type.GetType(className);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            StringBuilder sb = new StringBuilder();
            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType.Name}");
            }

            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return sb.ToString();
        }
    }
}
