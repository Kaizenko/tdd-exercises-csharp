using System;

namespace Kaizenko.Temperature
{
    public class TemperatureConverter
    {
        public int ConvertCtoF(int tempInC)
        {
           return tempInC * 9 / 5 + 32;
            
         
           
        }
    }
}