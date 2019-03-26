using System;
using Testing.Math;

namespace Testing
{
    class Program
    {
         static void Main(string[] args)
        {
            var james = new Person
            {
                FirstName = "James",
                LastName = "Schultz"
            };

            var numbers = new int[3]{1,2,3};
            Console.WriteLine(numbers[1]);
            
            var names = new string[3]{"James","Nick","Meredith"};
            Console.WriteLine(names[1]);

            var jon = new Person();
            james.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(3,4);
            Console.WriteLine(result);

            var shippingPreference = ShippingMethods.Shipping.SecondDayDelivery;
            Console.WriteLine((int)shippingPreference);

            var x = 3;
            var y = x;
                x = 4;
            Console.WriteLine(y);

            var namesArray = new string[3]{"foo","bar","bat"};
            var namesArray2 = namesArray;
                namesArray2[1] = "butts";
            Console.WriteLine(namesArray[1]);

        }
    } 
}