using NUnit.Framework;
using System;

namespace Kaizenko.Temperature.Tests
{
    public class TemperatureConverterTests
    {
        [Test]
        public void CovertCtoF_When0C_Expect32F()
        {
            //arrange
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            //act
            int tempInF = temperatureConverter.ConvertCtoF(0);
            //assert
            Assert.AreEqual(32, tempInF);
        }

        [Test]
        public void ConvertCtoF_When100C_Expect212F()
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            int tempInF = temperatureConverter.ConvertCtoF(100);
            Assert.AreEqual(212, tempInF);
        }

        [Test]
        public void ConvertCtoF_WhenNegative40C_ExpectNegative40F()
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            int tempInF = temperatureConverter.ConvertCtoF(-40);
            Assert.AreEqual(-40, tempInF);
        }

        [Test]
        public void ConvertCtoF_When25C_Expect_77F()
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            int tempInF = temperatureConverter.ConvertCtoF(25);
            Assert.AreEqual(77, tempInF);
        }
     

    }
}
