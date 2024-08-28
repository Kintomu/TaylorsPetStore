using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsPetStore
{
    internal interface IProductLogic
    {
        public void AddProduct(Product product);

        public DogLeash GetDogLeashByName(string name);

        public CatFood GetCatFoodByName(string name);

        public List<Product> GetAllProducts();

        public decimal GetTotalPriceOfInventory();

        public Product GetProductByName(string name);

    }
}
