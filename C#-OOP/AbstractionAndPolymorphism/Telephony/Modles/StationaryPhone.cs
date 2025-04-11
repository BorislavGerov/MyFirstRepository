using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Modles.Interfaces;

namespace Telephony.Modles
{
    internal class StationaryPhone : ICalling
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Dailing..{phoneNumber}";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(c => char.IsDigit(c));
        }
    }
}
