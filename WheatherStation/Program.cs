using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherStation.source;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            source.WeatherStation.printMeteostation();
        }
    }
}
