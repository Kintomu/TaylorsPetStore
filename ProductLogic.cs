using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsPetStore
{
    internal class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashCollection = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> _catFoodCollection = new Dictionary<string, CatFood>(); 

        public ProductLogic() 
        {
            _products = new List<Product>();        
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
            catch(Exception ex)
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
    }
}
