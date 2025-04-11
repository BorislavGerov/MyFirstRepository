using DefinaAnInterfaceIPerson.Core;
using DefinaAnInterfaceIPerson.Core.Interfaces;

namespace AbstractionAndPolymorphism
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
