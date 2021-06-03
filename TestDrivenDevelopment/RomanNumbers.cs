using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public static class RomanNumbers
    {
        //Expand This, to add more numbers. The method will then update beyond 9000. Just gonna let it stay at 9000 now though.
        public static Dictionary<int, string> Numbers = new Dictionary<int, string>() { { 1, "I" },  { 2, "II"}, { 3, "III"},
                                                                               { 4, "IV"}, { 5, "V"}, {6,"VI" },
                                                                               {7,"VII"}, {8,"VIII" },{9, "IX" },
                                                                               {10, "X" }, {100,"C" }, {1000,"M" },
                                                                               {20,"XX" }, {200, "CC" },  {2000,"MM" },
                                                                               {30,"XXX" }, {300,"CCC" },   {3000,"MMM" },
                                                                               {40,"XL" },  {400,"CD" }, {4000,"MV" },
                                                                               {50,"L" },  {500,"D" },  {5000,"V" },
                                                                               {60,"LX" }, {600,"DC" }, {6000,"VM" },  {70,"LXX" },
                                                                               {700,"DCC" },{7000,"VMM" },  {80,"LXXX" },  {800,"DCCC" },
                                                                               {8000,"VMMM"},{90,"XC" },  {900,"CM" }, {9000,"IX"} };
        public static string AddZeroes(int i, string number)
        {
            string zeros = "";
            int d = i;
            while (d != number.Length - 1)
            {
                zeros += "0";
                d++;
            }
            return zeros;
        }
    }
}
   
