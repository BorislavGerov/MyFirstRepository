using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests
{
    public class PromotionTests
    {
        private PromotionServise promotionServise;

        [SetUp]
        public void SetUp()
        {
            promotionServise = new PromotionServise();
        }

        [Test]
        public void When_Promotion_ShoulReturn_CorrectPrice_WhenDayIsFriday()
        {
            promotionServise = new PromotionServise(new DateTime(2025, 04, 25));
            Assert.AreEqual(80, promotionServise.GetPrice(100));
        }

        [Test]
        public void PromotionServise_ShouldReturn_CorrectPrice_WhenItsNotFriday()
        {
            promotionServise.GetPrice(100);
            Assert.AreEqual(100, 100);
        }

    }
}
