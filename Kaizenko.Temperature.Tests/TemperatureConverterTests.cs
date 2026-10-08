using NUnit.Framework;
using System;

namespace Kaizenko.Temperature.Tests
{
    public class TemperatureConverterTests
    {
        [Test]
        public void ConvertCtoF_When0C_Expect32F()
        {
            TemperatureConverter tempConverter = new();
            var tempInF = tempConverter.Convert(0);
            Assert.That(tempInF, Is.EqualTo(32));
        }

        [Test]
        public void ConvertCtoF_When100C_Expect212F()
        {
            TemperatureConverter tempConverter = new();
            var tempImF = tempConverter.Convert(100);
            Assert.That(tempImF, Is.EqualTo(212));
        }

        [Test]
        public void ConvertCtoF_WhenMinus40C_ExpectMinus40F()
        {
            TemperatureConverter tempConverter = new();
            var tempInF = tempConverter.Convert(-40);
            Assert.That(tempInF, Is.EqualTo(-40));
        }

         [Test]
        public void ConvertCtoF_WhenMinus37C_ExpectMinus98Point6F()
        {
            TemperatureConverter tempConverter = new();
            var tempInF = tempConverter.Convert(37);
            Assert.That(tempInF, Is.EqualTo(98.6));
        }

        [TestCase(0, 32)]
        [TestCase(100, 212)]
        [TestCase(-40, -40)]
        [TestCase(37, 98.6)]
        public void ConvertCtoF(double tempInC, double expectedTempInF)
        {
             TemperatureConverter tempConverter = new();
            var tempInF = tempConverter.Convert(tempInC);
            Assert.That(tempInF, Is.EqualTo(expectedTempInF));
        }
    }
}
