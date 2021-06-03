using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TestDrivenDevelopment;

namespace TestOfTestDrivenDevelopment
{   
    

    [TestClass]
    public class UnitTest
    {
        RomanNumberGenerator rng;
        Random random;
        [TestInitialize]
        public void Initialize()
        {
            rng = new RomanNumberGenerator();
            random = new Random();
        }
        [TestMethod]
        public void ThereIsNoNull()
        {
            string i = null;
            Assert.ThrowsException<ArgumentException>(() => rng.ConvertToRomanNumbers(i));
            Assert.ThrowsException<ArgumentException>(() => rng.ConvertToRomanNumbers(string.Empty));

        }

        [TestMethod]
        public void ThereIsNoLettersInThisString()
        {
            string i = "1231414ABCD";

            Assert.ThrowsException<ArgumentException>(() =>(rng.ConvertToRomanNumbers(i)));
        }
        [TestMethod]
        public void OneisI()
        {
            string i = "1";

            var obj = rng.ConvertToRomanNumbers(i);

            Assert.AreEqual(obj, "I");
        }
        [TestMethod]
        public void TwoIsII()
        {
            string i = "2";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "II");
        }
        [TestMethod]
        public void ThreeIsIII()
        {
            string i = "3";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "III");
        }
        [TestMethod]
        public void FourIsIV()
        {
            string i = "4";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "IV");
        }
        [TestMethod]
        public void FiveIsV()
        {
            string i = "5";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "V");
        }
        [TestMethod]
        public void SixIsVI()
        {
            string i = "6";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "VI");
        }
        public void SevenISVII()
        {
            string i = "7";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "VII");
        }
        [TestMethod]
        public void EightIsVIII()
        {
            string i = "8";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "VIII");
        }
        [TestMethod]
        public void NineIsIX()
        {
            string i = "9";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "IX");
        }
        [TestMethod]
        public void TenIsX()
        {
            string i = "10";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "X");
        }
        [TestMethod]
        public void HundredIsC()
        {
            string i = "100";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "C");
        }
        [TestMethod]
        public void ThousandIsM()
        {
            string i = "1000";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "M");
        }
        [TestMethod]
        public void TwentyIsXX()
        {
            string i = "20";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "XX");
        }
        [TestMethod]
        public void TwoHundredIsCC() 
        {
            string i = "200";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "CC");
        }
        [TestMethod]
        public void TwoThousandIsMM()
        {
            string i = "2000";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "MM");
        }
        [TestMethod]
        public void ThírtyIsXXX()
        {
            string i = "30";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "XXX");
        }
        [TestMethod]
        public void ThreeHundredIsCCC()
        {
            string i = "300";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "CCC");
        }
        [TestMethod]
        public void ThreeThousandIsMMM()
        {
            string i = "3000";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj,"MMM");
        }
        [TestMethod]
        public void FourtyIsXL()
        {
            string i = "40";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "XL");
        }
        [TestMethod]
        public void FourHundredIsCD()
        {
            string i = "400";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "CD");
        }
        [TestMethod]
        public void FourThousandIsMV()
        {
            string i = "4000";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "MV");
        }
        [TestMethod]
        public void FiftyIsL()
        {
            string i = "50";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "L");
        }
        [TestMethod]
        public void FiveHundredIsL()
        {
            string i = "500";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "D");
        }
        [TestMethod]
        public void FiveThousandIsL()
        {
            string i = "5000";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "V");
        }
        [TestMethod]
        public void SixtyIsLX()
        {
            string i = "60";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "LX");
        }
        [TestMethod]
        public void SixHundredIsDC()
        {
            string i = "600";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "DC");
        }
        [TestMethod]
        public void SeventyIsLXX()
        {
            string i = "70";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "LXX");
        }
        [TestMethod]
        public void SevenHundredIsLX()
        {
            string i = "700";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "DCC");
        }
        [TestMethod]
        public void EightyIsLXX()
        {
            string i = "80";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "LXXX");
        }
        [TestMethod]
        public void EightHundredIsLX()
        {
            string i = "800";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "DCCC");
        }
        [TestMethod]
        public void NinetyIsLXX()
        {
            string i = "90";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "XC");
        }
        [TestMethod]
        public void NineHundredIsLX()
        {
            string i = "900";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "CM");
        }
        [TestMethod]
        public void RandomNumbersWhichIs1421()
        {
            string i = "1421";
            var obj = rng.ConvertToRomanNumbers(i);
            Assert.AreEqual(obj, "MCDXXI");
        }

    }
}
