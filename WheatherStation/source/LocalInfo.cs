using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.source;

namespace WeatherStation.source
{
    class LocalInfo : Sensor
    {
        private static double lon, lat;
        private static int id;
        private static string main, description, icon, country, name;
        private static uint dt, sunrise, sunset;
        private static DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        private static DateTime sunriseDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        private static DateTime sunsetDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
        public static void scanLocalInfo()
        {
            dynamic coord = weatherst.coord;
            dynamic weather = weatherst.weather;
            dynamic sys = weatherst.sys;
            lon = coord.lon;
            lat = coord.lat;
            id = weather[0].id;
            main = weather[0].main;
            description = weather[0].description;
            icon = weather[0].icon;
            dt = weatherst.dt;
            dtDateTime = dtDateTime.AddSeconds(dt).ToLocalTime();
            country = sys.country;
            sunrise = sys.sunrise;
            sunriseDateTime = sunriseDateTime.AddSeconds(sunrise).ToLocalTime();
            sunset = sys.sunset;
            sunsetDateTime = sunsetDateTime.AddSeconds(sunset).ToLocalTime();
            name = weatherst.name;
        }
        public static double getLon()
        {
            return lon;
        }
        public static double getLat()
        {
            return lat;
        }
        public static int getId()
        {
            return id;
        }
        public static string getMain()
        {
            return main;
        }
        public static string getDescription()
        {
            return description;
        }
        public static string getIcon()
        {
            return icon;
        }
        public static string getCountry()
        {
            return country;
        }
        public static string getName()
        {
            return name;
        }
        public static DateTime getDt()
        {
            return dtDateTime;
        }
        public static DateTime getSunrise()
        {
            return sunriseDateTime;
        }
        public static DateTime getSunset()
        {
            return sunsetDateTime;
        }
    }
}
