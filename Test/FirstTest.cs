using HuaweiCloud.SDK.Core.Auth;
using NUnit.Framework;

namespace Test
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.That(IamService.DefaultIamEndpoint, !Is.Empty);
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int a = 5, b = 3;
            int result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(8));
        }

        [TestCase(1, 2, 3)]
        [TestCase(-1, 5, 4)]
        public void Add_ParameterizedTests(int a, int b, int expected)
        {
            int result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
        
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
    }
}
