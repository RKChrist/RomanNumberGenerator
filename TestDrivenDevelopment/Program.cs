using System;

namespace TestDrivenDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Write a Number");
            string number = Console.ReadLine();
            RomanNumberGenerator rng = new RomanNumberGenerator();
            try
            {
                var romanNumbers = rng.ConvertToRomanNumbers(number);
                Console.WriteLine(romanNumbers);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
