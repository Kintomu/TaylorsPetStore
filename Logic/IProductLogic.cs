using PetStore.Data.Models;

namespace TaylorsPetStore
{
    internal interface IProductLogic
    {
        public void AddProduct(Product product);

        public List<Product> GetAllProducts();

        public decimal GetTotalPriceOfInventory();

        public T GetProductByName<T>(string name) where T : Product;
        
        public List<String> GetOnlyInStockProducts();

    }
}
