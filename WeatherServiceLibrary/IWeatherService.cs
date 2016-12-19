using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the
    //interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        WeatherData GetWeather(string Location);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        void NotIncluded();

        // TODO: Add your service operations here
    }

    [DataContract]
    public class WeatherData
    {
        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public double RiskOfRain { get; set; }

        [DataMember]
        public double WindStrength { get; set; }

        public WeatherData(string location, double riskOfRain, double windStrength)
        {
            Location = location;
            RiskOfRain = riskOfRain;
            WindStrength = windStrength;
        }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WeatherServiceLibrary.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
