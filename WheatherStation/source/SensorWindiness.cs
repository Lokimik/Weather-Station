using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.source;

namespace WeatherStation.source
{
    class SensorWindiness : Sensor
    {
        private static double speed, deg;
        private static int all, visibility;
        public static void scanWindiness()
        {
            dynamic wind = weatherst.wind;
            dynamic cloudJson = weatherst.clouds;
            visibility = weatherst.visibility;
            all = cloudJson.all;
            speed = wind.speed;
            deg = wind.deg;
        }
        public static double getSpeed()
        {
            return speed;
        }
        public static double getDeg()
        {
            return deg;
        }
        public static int getAll()
        {
            return all;
        }
        public static int getVisibility()
        {
            return visibility;
        }
    }
}
