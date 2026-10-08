using System;

namespace Kaizenko.Temperature
{
    public class TemperatureConverter
    {
        public double Convert(double tempInC)
        {
           return Math.Round(tempInC*9.0/5,1)+32;

        }
    }
}