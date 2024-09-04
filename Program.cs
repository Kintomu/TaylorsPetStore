using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using TaylorsPetStore;


internal class Program
{
    private static void Main(string[] args)
    {
        IServiceProvider serviceProvider = CreateServiceCollection();

        Console.WriteLine("Welcome to Taylor's Pet Store");
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Press 2 to check product list");
        Console.WriteLine("Type 'exit' to quit");

        string userInput = Console.ReadLine();
        var productLogic = serviceProvider.GetService<IProductLogic>();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                Console.WriteLine("Press 1 to add a Cat Food, Press 2 to add a Dog Leash");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    AddCatFood(productLogic);
                }
                else if (userInput == "2")
                {
                    AddDogLeash(productLogic);
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Would you like a list of in stock products and their total value? y/n?");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    foreach (var product in productLogic.GetAllProducts().InStock())
                    {
                        Console.WriteLine(product.Name);
                    }
                    Console.WriteLine("Total Price of Inventory: $" + productLogic.GetTotalPriceOfInventory().ToString());
                }
                else if (userInput == "n")
                {

                    Console.WriteLine("Enter the name of the product you would like to look up");
                    userInput = Console.ReadLine();

                    LookupProduct(productLogic, userInput);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to check product list");
            Console.WriteLine("Type 'exit' to quit");

            userInput = Console.ReadLine();
        }
    }
    private static void AddCatFood(IProductLogic productLogic)
    {
        var catFood = new CatFood();
        catFood.AddProduct(catFood);
        catFood.AddCatfood(catFood);
        productLogic.AddProduct(catFood);
        Console.WriteLine(catFood.Name + " Added Successfully!");
        catFood.ProductDetails(catFood);
        catFood.CatFoodDetails(catFood);
    }

    private static void AddDogLeash(IProductLogic productLogic)
    {
        var dogLeash = new DogLeash();
        dogLeash.AddProduct(dogLeash);
        dogLeash.AddDogLeash(dogLeash);
        productLogic.AddProduct(dogLeash);
        Console.WriteLine(dogLeash.Name + " Added Successfully!");
        dogLeash.ProductDetails(dogLeash);
        dogLeash.DogLeashDetails(dogLeash);
    }

    private static void LookupProduct(IProductLogic productLogic, string userInput)
    {
        var product = productLogic.GetProductByName(userInput);

        if (product != null)
        {
            product.ProductDetails(product);

            if (product is DogLeash dogLeash)
            {
                dogLeash.DogLeashDetails(dogLeash);
            }
            else if (product is CatFood catFood)
            {
                catFood.CatFoodDetails(catFood);
            }
        }
        else
        {
            Console.WriteLine("No Product Found");
        }
    }

    private static IServiceProvider CreateServiceCollection()
    {
       return new ServiceCollection()
        .AddTransient<IProductLogic, ProductLogic>()
        .BuildServiceProvider();
    }
}