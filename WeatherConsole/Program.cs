using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherConsole.WeatherServiceReference;

namespace WeatherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherServiceClient client =
                new WeatherServiceClient();

            Console.WriteLine("Välkommen till vädertjänsten!");
            Console.Write("Vilken plats vill du veta vädret på? ");
            string location = Console.ReadLine();
            WeatherData data = client.GetWeather(location);
            if (data == null)
            {
                Console.WriteLine("Kunde inte hitta något väder");
            }
            else
            {
                Console.WriteLine("Vädret på " + data.Location
                    + " är " + data.RiskOfRain + "% regnrisk och "
                    + data.WindStrength + " m/s vind.");
            }
            Console.ReadKey();
        }
    }
}
