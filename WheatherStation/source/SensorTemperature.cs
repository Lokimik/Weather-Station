using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.source;

namespace WeatherStation.source
{
    class SensorTemperature : Sensor
    {
        private static double temp_min, temp_max, temp;
        public static void scanTemperature()
        {
            dynamic mainJson = weatherst.main;
            temp = mainJson.temp;
            temp_min = mainJson.temp_min;
            temp_max = mainJson.temp_max;
        }
        public static double getTemp_min()
        {
            return temp_min;
        }
        public static double getTemp_max()
        {
            return temp_max;
        }
        public static double getTemp()
        {
            return temp;
        }
    }
}
