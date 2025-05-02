using Store.Engine;
using Store.Engine.Contracts;
using Store.Models;
using Store.Models.Contracts;

namespace MockExcercises
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IPromotionServise promotionServise = new PromotionServise();
            IEnumerable<Product> products = new List<Product>()
            {
                new Product(200, "Bread"),
                new Product(100, "Oats")
                
            };

            IEngine engine = new Engine(products, promotionServise);


            engine.Run();
        }
    }
}
