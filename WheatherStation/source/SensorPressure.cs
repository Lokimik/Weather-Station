using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.source;

namespace WeatherStation.source
{
    class SensorPressure : Sensor
    {
        private static double pressure;
        public static void scanPressure()
        {
            dynamic mainJson = weatherst.main;
            pressure = mainJson.pressure;
        }
        public static double getPressure()
        {
            return pressure;
        }
    }
}
