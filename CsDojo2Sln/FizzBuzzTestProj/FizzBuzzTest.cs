using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzProj;

namespace FizzBuzzTestProj
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Test_Is_Fizz()
        {
            //Arrange
            int num = 3;
            var fizzbuzz = new FizzBuzz();

            //Act
            var result = fizzbuzz.Decode(num);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void Test_Is_Buzz()
        {
            int num = 5;
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.Decode(num);

            Assert.AreEqual("Buzz",result);
        }

        [TestMethod]
        public void Test_Is_number()
        {
            int num = 7;
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.Decode(num);
            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void Test_Is_FizzBuzz()
        {
            int num = 15;
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.Decode(num);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void Test_Range_From_10_To_15()
        {
            int min = 10;
            int max = 15;
            var fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.Print(min, max);
            Assert.AreEqual("Buzz,11,Fizz,13,14,FizzBuzz", result);
        }

        
       
    }
}
