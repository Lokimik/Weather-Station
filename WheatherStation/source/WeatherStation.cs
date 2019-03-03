using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.source;

namespace WeatherStation.source
{
    class WeatherStation 
    {
        public static void printMeteostation()
        {
            Console.WriteLine("Weather in Odessa today:");
            Console.WriteLine("---------------------------- -------------------- ----------------------------");
            Console.WriteLine("Information about the city: ");
            LocalInfo.scanLocalInfo();
            SensorTemperature.scanTemperature();
            SensorWindiness.scanWindiness();
            SensorPressure.scanPressure();
            SensorHumidity.scanHumidity();
            Console.Write("- Name: ");
            Meteostation.printInfo(LocalInfo.getName);
            Console.Write("- Country: ");
            Meteostation.printInfo(LocalInfo.getCountry);
            Console.WriteLine("Coord: ");
            Console.Write("- Longitude: ");
            Meteostation.printCoord(LocalInfo.getLon);
            Console.Write("- Latitude: ");
            Meteostation.printCoord(LocalInfo.getLat);
            Console.Write("Given at the time: ");
            Meteostation.printTime(LocalInfo.getDt);
            Console.Write("- Time to sunrise: ");
            Meteostation.printTime(LocalInfo.getSunrise);
            Console.Write("- Time to sunset: ");
            Meteostation.printTime(LocalInfo.getSunset);
            Console.WriteLine("Weather today: ");
            Console.Write("- Id: ");
            Meteostation.printId(LocalInfo.getId);
            Console.Write("- Main: ");
            Meteostation.printInfo(LocalInfo.getMain);
            Console.Write("- Description: ");
            Meteostation.printInfo(LocalInfo.getDescription);
            Console.Write("- Icon: ");
            Meteostation.printInfo(LocalInfo.getIcon);
            Console.Write("- Temperature: ");
            Meteostation.printTemperature(SensorTemperature.getTemp);
            Console.Write("- Minimal temperature: ");
            Meteostation.printTemperature(SensorTemperature.getTemp_min);
            Console.Write("- Maximal temperature: ");
            Meteostation.printTemperature(SensorTemperature.getTemp_max);
            Console.Write("- Pressure: ");
            Meteostation.printPressure(SensorPressure.getPressure);
            Console.Write("- Humidity: ");
            Meteostation.printHumidity(SensorHumidity.getHumidity);
            Console.WriteLine("Wind today: ");
            Console.Write("- Speed: ");
            Meteostation.printWindiness(SensorWindiness.getSpeed);
            Console.Write("- Degree: ");
            Meteostation.printWindiness(SensorWindiness.getDeg);
            Console.WriteLine("Clouds today: ");
            Console.Write("- All: ");
            Meteostation.printCloud(SensorWindiness.getAll);
            Console.Write("- Visibility: ");
            Meteostation.printCloud(SensorWindiness.getVisibility);
        }
    }
}
