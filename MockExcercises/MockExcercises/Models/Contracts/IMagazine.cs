using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models.Contracts
{
    public interface IMagazine
    {
        public IEnumerable<Product> Products { get; }

        public decimal GetProductPrice(string name);
    }
}
