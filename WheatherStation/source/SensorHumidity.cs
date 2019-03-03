using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.source;

namespace WeatherStation.source
{
    class SensorHumidity : Sensor
    {
        private static double humidity;
        public static void scanHumidity()
        {
            dynamic mainJson = weatherst.main;
            humidity = mainJson.humidity;
        }
        public static double getHumidity()
        {
            return humidity;
        }
    }
}
