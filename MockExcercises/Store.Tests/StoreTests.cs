using Moq;
using Store.Models;
using Store.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests
{
    public class StoreTests
    {
        Mock<IPromotionServise> promotionService = new Mock<IPromotionServise>();
        private Magazine store;
        private IEnumerable<Product> products = new List<Product>()
        {
            new Product(100.5m, "Beer"),
            new Product(200m, "Bread")
        };
        

        [SetUp]
        public void SetUp()
        {
            promotionService.Setup(p => p.GetPrice(It.IsAny<decimal>())).Returns(55);
            IPromotionServise pServise = promotionService.Object;
            store = new Magazine(products ,pServise);
           
        }

        [Test]
        public void When_CreateMagazine_Data_ShouldBeSet_Correctly()
        {
            Assert.IsNotNull(store);
        }

        [Test]
        public void When_GetProductPrice_SHouldReturn_Correct_Price()
        {
            Assert.AreEqual(55, store.GetProductPrice(products.First(p => p.Name == "Bread").Name));
        }
    }
}
