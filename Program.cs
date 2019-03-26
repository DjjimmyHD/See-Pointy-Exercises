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
        }
    } 
}