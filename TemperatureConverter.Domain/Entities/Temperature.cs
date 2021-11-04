using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConverter.Domain.Enums;

namespace TemperatureConverter.Domain.Entities
{
    public class Temperature
    {
        public double Value { get; set; }
        public TemperatureScale TemperatureScale { get; set; }
    }
}
