using Inheritance;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var zapdos = new Bird
            {
                Name = "Zapdos",
                Age = 100, 
                Legs = 2,
                HasBackbone = true,
                HasFeathers = true,
                IsWarmBlooded = true,
                Type = "electric",
                Wings = 2
            };

            Console.WriteLine($"{zapdos.Name} is an {zapdos.Type} pokemon that is {zapdos.Age} years old and has {zapdos.Legs} legs and {zapdos.Wings}wings.");

            Console.WriteLine($" Is {zapdos.Name} a vertibrate, warm blooded, and has feathers? {zapdos.HasBackbone}, {zapdos.IsWarmBlooded}, and {zapdos.HasFeathers}");

            //        Bird = "zapdos",
            //            Age = 1000,
            //            Legs = 2,
            //            HasBackBone = true,
            //            IsWarmBlooded = true,
            //            HasFeathers = true,
            //            Wings = 2,
            //            Type = "electric",
            //    }
            //    Console.WriteLine($"{zapdos.Name} is an {zapdos.Type} pokemon that is {zaptos.Age} 
            //        years old and has { zapdos.Legs } legs and { zapdos.Wings } wings.");

            //        Console.WriteLine($" Is (zapdos.Name} a vertibrate, warm blooded, and has feathers?" {zapdos.HasBackBone }, 
            //        zapdos.IsWarmBlooded }, and { zapdos.HasFeathers}");
            //    Console.Write.Line()
            //    {
            //     Reptile dragon = newReptile()

            //    {
            //        Name = "Smaug",
            //        Age = 1200,
            //        Legs = 4,
            //        HasBackBone = true,
            //        IsColdBlooded = true,
            //        HasScaled = true,
            //        Environment = "Erebor:", 
            //        Defense = "breathes fire",
            //    }
            //     Console.WriteLine ($"Is {dragon.Name} a vertibrate, cold blooded, and has scales? {dragon.HasBackBone, {dragon.IsColdBlooded}, and 
            //         {dragon.HasScales});

            //         Console.WriteLine();

            //        // TODO Be sure to follow best practice when creating your classes

            //        // Create a class Animal
            //        // give this class 4 members that all Animals have in common


            //        // Create a class Bird
            //        // give this class 4 members that are specific to Bird
            //        // Set this class to inherit from your Animal Class

            //        // Create a class Reptile
            //        // give this class 4 members that are specific to Reptile
            //        // Set this class to inherit from your Animal Class




            //        /*Create an object of your Bird class
            //         *  give values to your members using the object of your Bird class
            //         *  
            //         * Creatively display the class member values 
            //         */

            //        /*Create an object of your Reptile class
            //         *  give values to your members using the object of your Reptile class
            //         *  
            //         * Creatively display the class member values 
            //         */

            //}
        }
    }
    
}