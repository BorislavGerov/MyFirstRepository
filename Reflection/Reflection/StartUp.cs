
using System.Reflection;

namespace Stealer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
           Spy spy = new Spy();
            Console.WriteLine(spy.GettersAndSetters("Stealer.Hacker"));
        }
    }
}
