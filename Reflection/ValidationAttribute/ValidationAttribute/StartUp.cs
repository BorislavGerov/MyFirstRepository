using ValidationAttribute.Core;
using ValidationAttribute.Core.Interfaces;

namespace ValidationAttribute
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
