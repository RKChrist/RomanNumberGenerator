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
            RomanNumbersToINTGenerator rntig = new RomanNumbersToINTGenerator();
            try
            {
                var romanNumbers = rng.ConvertToRomanNumbers(number);
                Console.WriteLine(romanNumbers);
                var normalnumbers = rntig.ConvertToInt(romanNumbers);
                Console.WriteLine(normalnumbers);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
