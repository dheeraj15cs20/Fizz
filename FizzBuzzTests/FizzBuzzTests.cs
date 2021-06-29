using Fizz;
using NUnit.Framework;

namespace FizzBuzzTests
{   [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1,"1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        [TestCase(12, "Fizz")]
        [TestCase(20, "Buzz")]
        

        public void FizzBuzzer_Givenint1_return1String(int input, string expected)
        {
            
            FizzBuzzer fb = new FizzBuzzer();
            string actual = fb.FizzBuzz(input);
            Assert.AreEqual(expected, actual);

        }
    }
}
