using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsPetStore
{
    internal class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashCollection = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> _catFoodCollection = new Dictionary<string, CatFood>();

        public ProductLogic()
        {
            _products = new List<Product>();

            AddProduct(new DogLeash { Name = "Nylon Dog Leash", Price = 12.99m, Quantity = 5, Description = "Durable nylon leash for dogs", LengthInches = 60, Material = "Nylon" });
            AddProduct(new DogLeash { Name = "Leather Dog Leash", Price = 24.99m, Quantity = 0, Description = "Premium leather leash for dogs", LengthInches = 48, Material = "Leather" });
            AddProduct(new CatFood { Name = "Kitten Chow", Price = 8.49m, Quantity = 3, Description = "Complete nutrition for kittens", WeightPounds = 5.0, KittenFood = true });
            AddProduct(new CatFood { Name = "Adult Cat Food", Price = 10.99m, Quantity = 10, Description = "Balanced diet for adult cats", WeightPounds = 10.0, KittenFood = false });            
        }

        public void AddProduct(Product product)
        {
            if (product is CatFood)
            {
                _catFoodCollection.Add(product.Name, product as CatFood);
            }
            if (product is DogLeash)
            {
                _dogLeashCollection.Add(product.Name, product as DogLeash);
            }

            _products.Add(product);
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeashCollection[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CatFood GetCatFoodByName(string name)
        {
            try
            {
                return _catFoodCollection[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public List<string> GetOnlyInStockProducts()
        {
            return _products.Where(x => x.Quantity > 0).Select(x => x.Name).ToList();
        }
    }
}
