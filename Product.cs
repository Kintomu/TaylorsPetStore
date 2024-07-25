using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsPetStore
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product AddProduct(Product product)
        {
            product = AddProductName(product);
            product = AddProductDescription(product);
            product = AddProductPrice(product);
            product = AddProductQuantity(product);

            return product;
        }
        public void ProductDetails(Product product)
        {
            Console.WriteLine("Your Product's Name is " + product.Name + " with a Description of " + product.Description);
            Console.WriteLine(product.Name + " costs $" + product.Price + " and has " + product.Quantity + " in stock.");
        }

        protected Product AddProductName(Product product)
        {
            Console.WriteLine("What is the Name of the Product?");
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
            {
                product.Name = input;
                return product;
            }
            else
            {
                Console.WriteLine("Invalid Name Format");
            }
            return product;
        }

        protected Product AddProductPrice(Product product)
        {
            Console.WriteLine("What is the Price of " + product.Name + "?");
            var input = Console.ReadLine();
            if (Decimal.TryParse(input, out decimal result))
            {
                product.Price = result;
                return product;
            }
            else
            {
                Console.WriteLine("Invalid Price Format");
            }
            return product;
        }

        protected Product AddProductQuantity(Product product)
        {
            Console.WriteLine("What is the Quantity of " + product.Name + "?");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                product.Quantity = result;
                return product;
            }
            else
            {
                Console.WriteLine("Invalid Quantity Format");
            }
            return product;
        }

        protected Product AddProductDescription(Product product)
        {
            Console.WriteLine("What is the Description of " + product.Name + "?");
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
            {
                product.Description = input;
                return product;
            }
            else
            {
                Console.WriteLine("Invalid Description Format");
            }
            return product;
        }
    }
}
