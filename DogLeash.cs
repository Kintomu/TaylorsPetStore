using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsPetStore
{
    internal class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }

        public DogLeash AddDogLeash(DogLeash dogLeash)
        {
            dogLeash = AddLength(dogLeash);
            dogLeash = AddMaterial(dogLeash);

            return dogLeash;
        }

        public void DogLeashDetails(DogLeash dogLeash)
        {
            Console.WriteLine(dogLeash.Name + " is " + dogLeash.LengthInches + " inch(s) long and is made from " + dogLeash.Material);
        }

        protected DogLeash AddMaterial(DogLeash dogLeash)
        {
            Console.WriteLine("What material is " + dogLeash.Name + " made from?");
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
            {
                dogLeash.Material = input;
                return dogLeash;
            }
            else
            {
                Console.WriteLine("Invalid Material Format");
            }
            return dogLeash;
        }

        protected DogLeash AddLength(DogLeash dogLeash)
        {
            Console.WriteLine("What is the Length in inchs of " + dogLeash.Name + "?");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                dogLeash.LengthInches = result;
                return dogLeash;
            }
            else
            {
                Console.WriteLine("Invalid Length Format");
            }
            return dogLeash;
        }
    }
}
