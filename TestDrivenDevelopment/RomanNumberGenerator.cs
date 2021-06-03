using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class RomanNumberGenerator
    {   
       
                                                                                
        
        public string ConvertToRomanNumbers(string normalNumbers)
        {
            if (normalNumbers == null) throw new ArgumentException("Den insertede string kan ikke være null");
            if (normalNumbers.Length == 0 ) throw new ArgumentException("Den insertede string skal indeholde en værdi");
            if (!int.TryParse(normalNumbers, out var s)) throw new ArgumentException("Den insertede string skal kun indeholde numre ");

            return RomanNumbersConverter(normalNumbers);
        }
        private string RomanNumbersConverter(string number)
        {
            string romanNumbers = "";
            string zeros = "";
            for (int i = 0; i <= number.Length-1; i++)
            {
                if (number[i] == '0') continue;
                if (number[^1] == number[i] && i == number.Length)
                {
                    romanNumbers += RomanNumbers.Numbers[int.Parse(number[i].ToString())];
                    break;
                }
                int d =  i;
                while (d != number.Length -1)
                {
                    zeros += "0";
                    d++;
                }
                romanNumbers += RomanNumbers.Numbers[int.Parse(number[i].ToString() + zeros)];
                zeros = "";
            }
            return romanNumbers;
        }
       
    }
}
