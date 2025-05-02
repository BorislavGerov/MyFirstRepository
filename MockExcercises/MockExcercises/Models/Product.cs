using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        public Product(decimal price, string name)
        {
            Price = price;
            Name = name;
        }

        public decimal Price { get; set; }

        public string Name { get; set; }
    }
}
