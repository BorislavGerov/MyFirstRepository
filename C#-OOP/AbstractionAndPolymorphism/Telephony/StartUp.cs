using Telephony.Core;

namespace Telephony
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
