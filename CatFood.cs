using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsPetStore
{
    internal class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public CatFood AddCatfood(CatFood catFood)
        {
            catFood = AddWeight(catFood);
            catFood = IsKittenFood(catFood);

            return catFood;
        }

        public void CatFoodDetails(CatFood catFood)
        {
            var _forKittens = string.Empty;

            if (catFood.KittenFood)
            {
                _forKittens = " is for Kittens.";
            }
            else
            {
              _forKittens = " is not for Kittens.";
            }
            Console.WriteLine(catFood.Name + " weighs " + catFood.WeightPounds + " pound(s) and" + _forKittens);
        }

        protected CatFood AddWeight(CatFood catFood)
        {
            Console.WriteLine("What is the Weight in Pounds of " + catFood.Name + "?");
            var input = Console.ReadLine();
            if (double.TryParse(input,out double result))
            {
                catFood.WeightPounds = result;
                return catFood;
            }
            else
            {
                Console.WriteLine("Invalid Weight Format");
            }
            return catFood;
        }

        protected CatFood IsKittenFood(CatFood catFood)
        {
            Console.WriteLine("Is " + catFood.Name + " kitten food? Enter yes or no");
            var input = Console.ReadLine().ToLower();
            if (!String.IsNullOrEmpty(input))
            {
                if (input == "yes")
                {
                    catFood.KittenFood = true;
                    return catFood;
                }
                else if (input == "no")
                {
                    catFood.KittenFood = false;
                    return catFood;
                }
                else
                { 
                Console.WriteLine("Please respond with yes or no");
                }
            }
            else
            {
                Console.WriteLine("Invalid Response Format");
            }
            return catFood;
        }
    }
}
