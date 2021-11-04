using AppCore.Temperatures;
using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConverter.Domain.Entities;
using TemperatureConverter.Domain.Enums;
using TemperatureConverter.Domain.Interfaces;

namespace AppCore.Factories
{
    public static class TemperatureConverterFactory
    {
        public static ITemperatureConverter CreateInstance(Temperature temperature, TemperatureScale temperatureScale)
        {
            if(temperature.TemperatureScale == TemperatureScale.Celsius && temperatureScale == TemperatureScale.Fahrenheit)
            {
                return new CelsiusToFahrenheitConverter();
            }

            return null;
        }
    }
}
