using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests
{
    public class ProductTests
    {
        private Product product;

        [SetUp]
        public void SetUp()
        {
            product = new Product(100, "Bread");
        }

        [Test]
        public void When_CreateProduct_Data_ShouldBeSet_Correctly()
        {
            Assert.IsNotEmpty(product.Name);
            Assert.IsNotNull(product.Price);
        }
    }
}
