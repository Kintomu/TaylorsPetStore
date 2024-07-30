using System.Runtime.CompilerServices;
using System.Text.Json;
using TaylorsPetStore;

Console.WriteLine("Welcome to Taylor's Pet Store");
Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();
var productLogic = new ProductLogic();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        Console.WriteLine("Press 1 to add a Cat Food, Press 2 to add a Dog Leash");
        userInput = Console.ReadLine();
        if (userInput == "1")
        {
            var catFood = new CatFood();
            catFood.AddProduct(catFood);
            catFood.AddCatfood(catFood);
            productLogic.AddProduct(catFood);
            Console.WriteLine(catFood.Name + " Added Successfully!");
            catFood.ProductDetails(catFood);
            catFood.CatFoodDetails(catFood);
        }
        else if (userInput == "2")
        {
            var dogLeash = new DogLeash();
            dogLeash.AddProduct(dogLeash);
            dogLeash.AddDogLeash(dogLeash);
            productLogic.AddProduct(dogLeash);
            Console.WriteLine(dogLeash.Name + " Added Successfully!");
            dogLeash.ProductDetails(dogLeash);
            dogLeash.DogLeashDetails(dogLeash);
        }
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        userInput = Console.ReadLine();
    }
}


