using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsWeatherProject
{
    class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
    }
}
