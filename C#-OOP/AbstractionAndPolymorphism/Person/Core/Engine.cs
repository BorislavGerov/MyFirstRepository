using DefinaAnInterfaceIPerson.Core.Interfaces;
using DefinaAnInterfaceIPerson.Models;
using DefinaAnInterfaceIPerson.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Telephony.IO;
using Telephony.IO.Interfaces;

namespace DefinaAnInterfaceIPerson.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IWriter writter = new ConsoleWritter();
            IPerson person = new Citizen("Bobby", 22);
            writter.WriteLine(person.Name);
        }
    }
}
