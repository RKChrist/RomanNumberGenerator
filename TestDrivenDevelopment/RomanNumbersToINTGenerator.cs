using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class RomanNumbersToINTGenerator
    {
        //Bad Code for review later.
        /*
        int numbers = 0;
            bool BiggerThan3 = false;
            bool BiggerThan2 = false;
            if (romanNumbers == null && romanNumbers == string.Empty) throw new ArgumentException("Tilføj Værdi");
            if (romanNumbers.Length >= 3) BiggerThan3 = true;
            if (romanNumbers.Length >= 3) BiggerThan2 = true;
            foreach (var item in RomanNumbers.Numbers)
            {
                int newNumbers = 0;
                if (BiggerThan3)
                {
                    if (item.Value == romanNumbers.Substring(0, 3))
                    {
                        newNumbers = item.Key;
                        BiggerThan2 = false;
                    }
                }
                if (BiggerThan2)
                {
                    if (item.Value == romanNumbers.Substring(0,2))
                    {
                        newNumbers = item.Key;

                    }
                }
                if (BiggerThan2 || BiggerThan3)
                {
                    if (item.Value == romanNumbers[0].ToString())
                    {
                        newNumbers = item.Key;
                    }
                }
                numbers += newNumbers;
            }
            if (BiggerThan2 && romanNumbers.Length > 2)
            {
                numbers += ConvertToInt(romanNumbers.Substring(0, 2));
            }
            if (BiggerThan3 && romanNumbers.Length > 3)
            {
                numbers += ConvertToInt(romanNumbers.Substring(0, 3));
            }

            return numbers;
         */
        public int ConvertToInt(string romanNumbers)
        {
            int integers = 0;
            bool isMoreThan2 = false;
           
            if (romanNumbers.Length >= 2 )
            {
                isMoreThan2 = true;
            }
            foreach (var item in RomanNumbers.Numbers)
            {
                if (isMoreThan2)
                {
                    if (item.Value == romanNumbers.Substring(0,2))
                    {
                        integers += item.Key;
                        break;
                    }
                }
                if (romanNumbers.Length >= 1)
                {
                    if (item.Value == romanNumbers[0].ToString())
                    {
                        integers += item.Key;
                        
                        break;
                    }
                }
            }
            if (romanNumbers.Length != 1 && romanNumbers.Length != 0)
            {
                integers += ConvertToInt(romanNumbers.Substring(2));
            }
            return integers;
        }
    }
}
