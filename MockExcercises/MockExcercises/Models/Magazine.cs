using Store.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Magazine : IMagazine
    {
        private IPromotionServise promotionServise;

        public Magazine(IEnumerable<Product> products, IPromotionServise promotionServise)
        {
            Products = products;
            this.promotionServise = promotionServise;
        }

        public IEnumerable<Product> Products { get; private set; }

        public decimal GetProductPrice(string name)
        {
            return promotionServise.GetPrice(Products.First(p => p.Name == name).Price);
        }
    }
}
