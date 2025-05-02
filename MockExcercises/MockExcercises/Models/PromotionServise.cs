using Store.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class PromotionServise : IPromotionServise
    {
        private DateTime dateTime;

        public PromotionServise()
        {
            dateTime = DateTime.Now;
        }

        public PromotionServise(DateTime dateTime)
        {
            this.dateTime = dateTime; 
        }
        public decimal GetPrice(decimal price)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Friday)
            {
                return price - price * 0.2m;
            }

            return price;
        }
    }
}
