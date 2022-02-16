using System.Runtime.InteropServices;
using Calculator;
using NUnit.Framework;


namespace TestProject
{
    public class Tests
    {
        private SimpleCalculator _uut;

        [SetUp] 
        public void Setup()
        {
            _uut = new SimpleCalculator();
        }

        [TestCase(5, 2, 3)]
        [TestCase(-4, 2, -6)]
        [TestCase(4.3, 3, 1.3)]
        public void AddTest(double expected, double first, double second)
        {
            double sum = _uut.Add(first, second);
            Assert.That(expected, Is.EqualTo(sum));
        }

        [TestCase(5,7,2)]
        [TestCase(27,10,-17)]
        [TestCase(4.3, 6, 1.7)]
        public void SubtractTest(double expected, double first, double second)
        {
            double sum = _uut.Subtract(first, second);
            Assert.That(expected, Is.EqualTo(sum));
        }

        [TestCase(4,2,2)]
        [TestCase(-8,4,-2)]
        [TestCase(2.25,1.5,1.5)]
        public void MultiplyTest(double expected, double first, double second)
        {
            double sum = _uut.Multiply(first, second);
            Assert.That(expected, Is.EqualTo(sum));
        }

        [TestCase(4,2,2)]
        [TestCase(0.25,2,-2)]
        [TestCase(512,4,4.5)]
        public void PowerTest(double expected, double x, double exp)
        {
            double sum = _uut.Power(x, exp);
            Assert.That(expected, Is.EqualTo(sum));
        }

        [TestCase(2,4,2)]
        [TestCase(3,6,2)]
        [TestCase(2,5,2.5)]
        public void DivideTest(double expected, double first, double second)
        {
            double sum = _uut.Divide(first, second);
            Assert.That(expected, Is.EqualTo(sum));
        }

        [Test]
        public void ClearTest()
        {
            _uut.Clear();
            Assert.That(_uut.Accumulate, Is.EqualTo(0));
        }
    }
}