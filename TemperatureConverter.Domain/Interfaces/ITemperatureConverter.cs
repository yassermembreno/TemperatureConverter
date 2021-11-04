using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConverter.Domain.Entities;
using TemperatureConverter.Domain.Enums;

namespace TemperatureConverter.Domain.Interfaces
{
    public interface ITemperatureConverter
    {
        double convert(Temperature temperature);
    }
}
