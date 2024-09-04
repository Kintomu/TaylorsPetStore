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

        public List<Product> GetAllProducts();

        public decimal GetTotalPriceOfInventory();

        public T GetProductByName<T>(string name) where T : Product;

    }
}
