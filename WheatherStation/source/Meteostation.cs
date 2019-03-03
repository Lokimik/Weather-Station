using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.source;

namespace WeatherStation.source
{
    class Meteostation
    {
        public delegate double temperature();
        public delegate double pressure();
        public delegate double humidity();
        public delegate double windiness();
        public delegate int cloud();
        public delegate double coord();
        public delegate int id();
        public delegate string info();
        public delegate DateTime time();
        public static void printTemperature(temperature t)
        {
            Console.WriteLine(t());
        }
        public static void printPressure(pressure p)
        {
            Console.WriteLine(p());
        }
        public static void printHumidity(humidity h)
        {
            Console.WriteLine(h());
        }
        public static void printWindiness(windiness w)
        {
            Console.WriteLine(w());
        }
        public static void printCloud(cloud d)
        {
            Console.WriteLine(d());
        }
        public static void printCoord(coord c)
        {
            Console.WriteLine(c());
        }
        public static void printId(id id)
        {
            Console.WriteLine(id());
        }
        public static void printInfo(info i)
        {
            Console.WriteLine(i());
        }
        public static void printTime(time tm)
        {
            Console.WriteLine(tm());
        }
    }
}
