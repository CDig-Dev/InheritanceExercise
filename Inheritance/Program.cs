using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var woodStock = new Bird();
            woodStock.WingColor = "yellow";
            woodStock.CanFly = true;
            woodStock.DoesMigrate = true;
            woodStock.BeakLength = 3.5;
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizzie = new Reptile()
            {
                IsColdBlooded = true,
                HasScales = false,
                Habitat = "desert",
                RegenerativeTail = true,

            };

            var myAnimals = new Animal[] { woodStock, lizzie, };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age}");
                Console.WriteLine($"It has :{animal.LegCount} legs");
                Console.WriteLine($"It lives by the:{animal.LandSeaAir}");
                Console.WriteLine($"");
            }

        }
    }
}
