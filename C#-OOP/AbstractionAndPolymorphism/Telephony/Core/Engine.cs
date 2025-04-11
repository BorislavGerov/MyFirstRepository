using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.IO;
using Telephony.IO.Interfaces;
using Telephony.Modles;
using Telephony.Modles.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWritter();

            string[] phoneNumbers = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] urls = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            ICalling phone;
            foreach (var phoneNumber in phoneNumbers)
            {
                if(phoneNumber.Length == 10)
                {
                    phone = new SmartPhone();
                }
                else
                {
                    phone = new StationaryPhone();
                }

                try
                {
                    writer.WriteLine(phone.Call(phoneNumber));
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }

            IBrowse browse = new SmartPhone();
            foreach (var url in urls)
            {
                try
                {
                    writer.WriteLine(browse.Browse(url));
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }

            }
        }
    }
}
