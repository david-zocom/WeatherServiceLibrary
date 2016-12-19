using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IWeatherService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public WeatherData GetWeather(string Location)
        {
            // search database for latest weather report matching "location"
            WeatherData data = new WeatherData(Location, 0.2, 5);
            return data;
        }

        public void NotIncluded()
        {
            throw new NotImplementedException();
        }
    }
}
