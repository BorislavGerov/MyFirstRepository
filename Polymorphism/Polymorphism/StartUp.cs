using Polymorphism.Core;
using Polymorphism.Core.Interfaces;
using Polymorphism.IO;
using Polymorphism.IO.Interfaces;

namespace Polymorphism
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
