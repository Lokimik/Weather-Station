using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherStation.source
{
    public class Sensor
    {
        static public string json = new WebClient().DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Odessa,ua&appid=ca7b0aa591f3692feb0e838de707448b");
        static public dynamic weatherst = JsonConvert.DeserializeObject<dynamic>(json);
    }
}
