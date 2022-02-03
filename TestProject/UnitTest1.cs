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

        [TestCase(5)]
        public void AddTest(double expected)
        {
            double sum = _uut.Add(2, 3);
            Assert.That(expected, Is.EqualTo(sum));
        }
        
    }
}