using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzzKata;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ThreeDivisibleByThreeTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool divisible = fb.IsDivisibleByThree(3);
            Assert.That(divisible, Is.True);
        }

        [Test]
        public void FiveIsDivisibleByFiveTest()
        {
            FizzBuzz fb = new FizzBuzz();
            bool divisible = fb.IsDivisibleByFive(5);
            Assert.That(divisible, Is.True);
        }

        [Test]
        public void TextForDivisibleByThreeIsFizzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(3);
            Assert.That(text, Is.EqualTo("Fizz"));
        }

        [Test]
        public void TextForDivisibleByFiveIsFizzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(5);
            Assert.That(text, Is.EqualTo("Buzz"));
        }

        [Test]
        public void TextForDivisibleByThreeAndFiveIsFizzBuzzTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(15);
            Assert.That(text, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void TextForNotDivisibleByThreeNotFiveIsItselfText()
        {
            FizzBuzz fb = new FizzBuzz();
            string text = fb.GetTextForNumber(4);
            Assert.That(text, Is.EqualTo("4"));
        }

        [Test]
        public void CanDoTheWholeThingTest()
        {
            FizzBuzz fb = new FizzBuzz();
            string allofit = fb.DoTheWholeThing(15);
            Assert.That(allofit, Is.EqualTo("12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz"));
        }
    }
}
