using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConverter.Domain.Entities;
using TemperatureConverter.Domain.Enums;
using TemperatureConverter.Domain.Interfaces;

namespace AppCore.Temperatures
{
    public class CelsiusToFahrenheitConverter : ITemperatureConverter
    {
        public double convert(Temperature temperature)
        {
            return (temperature.Value * 1.8) + 32;
        }
    }
}
