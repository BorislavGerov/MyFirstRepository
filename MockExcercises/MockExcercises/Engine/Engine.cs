using Store.Engine.Contracts;
using Store.Models;
using Store.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store.Engine
{
    public class Engine : IEngine
    {
        private IPromotionServise promotionServise;
        private IEnumerable<Product> products;

        public Engine(IEnumerable<Product> products, IPromotionServise promotionServise)
        {
            this.products = products;
            this.promotionServise = promotionServise;
        }

        public void Run()
        {
            IMagazine magazine = new Magazine(products, promotionServise);
            string productName = Console.ReadLine();
            decimal price = magazine.GetProductPrice(productName);
            Console.WriteLine(price);
        }
    }
}
