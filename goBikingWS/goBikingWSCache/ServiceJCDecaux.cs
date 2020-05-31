using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace goBikingWSCache
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ServiceJCDecaux : IServiceJCDecaux
    {

        public static string responseFromServer = "Loading...";
        public static string APIKey = "4ac6adf65976da80457a56a4d84448e3c4b304c2";
        public static Dictionary<Contract, List<Station>> JCDecaux_data = new Dictionary<Contract, List<Station>>();


        //STATIC FUNCTION
        public static String getContracts()
        {
            Console.WriteLine("inside");
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
            "https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + APIKey);
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. string
            responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
            return responseFromServer;
        }

        public static String getStations(String cityName)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
            "https://api.jcdecaux.com/vls/v1/stations?contract=" + cityName + "&apiKey=" + APIKey);
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. string
            responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
            return responseFromServer;
        }


        public static Station findStation(int number)
        {
 
            foreach (Contract contract in JCDecaux_data.Keys)
            {
                foreach (Station station in JCDecaux_data[contract])
                {
                    Console.WriteLine(station.number.ToString());
                    if (station.number == number) return station;
                }
            }
            return null;
        }

        public static Contract findContract(string name)
        {
            foreach (Contract contract in JCDecaux_data.Keys)
            {
                if (contract.name.Equals(name)) return contract;
            }
            return null;
        }

        public static string refreshData()
        {
            string res_contracts = getContracts();
            JArray contracts = JArray.Parse(res_contracts);
            foreach (JObject contract in contracts)
            {
                string contract_name = contract["name"].ToString();
                string res_stations = getStations(contract_name);
                Contract contract_added = new Contract { name = contract["name"].ToString() };
                JCDecaux_data.Add(contract_added, new List<Station>());
                JArray stations = JArray.Parse(res_stations);
                foreach (JObject station in stations)
                {

                    int number = Int32.Parse(station["number"].ToString());
                    string name = station["name"].ToString();
                    string address = station["address"].ToString();
                    double lat = Convert.ToDouble(station["position"]["lat"]);
                    double lng = Convert.ToDouble(station["position"]["lng"]);
                    string status = station["status"].ToString();
                    int available_bikes = Int32.Parse(station["available_bikes"].ToString());

                    JCDecaux_data[contract_added].Add(new Station(number, contract_name, name, address, lat, lng, status, available_bikes));
                }
            }
            return "OK";
        }


        //OPERATION CONTRACT
        public List<Station> getStationsList(string contractName)
        {
            foreach (Contract contract in JCDecaux_data.Keys)
            {
                if (contract.name.Equals(contractName)) return JCDecaux_data[contract];
            }
            return null;
        }

        public List<Contract> getContractsList()
        {
            List<Contract> contracts = new List<Contract>();
            foreach(Contract contract in JCDecaux_data.Keys)
            {
                contracts.Add(contract);
            }
            return contracts;
        }

        public Station getStation(int number)
        {
            return findStation(number);
        }

        public Location getStationLocation(int number)
        {
            Station station = findStation(number);
            Location location = new Location(station.lat, station.lng);
            return location;
        }

        public Contract getContract(string name)
        {
            return findContract(name);
        }

        public string updateData()
        {
            string res_contracts = getContracts();
            JArray contracts = JArray.Parse(res_contracts);
            foreach (JObject contract in contracts)
            {
                string contract_name = contract["name"].ToString();
                string res_stations = getStations(contract_name);
                Contract contract_added = new Contract { name = contract["name"].ToString() };
                JCDecaux_data.Add(contract_added, new List<Station>());
                JArray stations = JArray.Parse(res_stations);
                foreach (JObject station in stations)
                {

                    int number = Int32.Parse(station["number"].ToString());
                    string name = station["name"].ToString();
                    string address = station["address"].ToString();
                    double lat = Convert.ToDouble(station["position"]["lat"]);
                    double lng = Convert.ToDouble(station["position"]["lng"]);
                    string status = station["status"].ToString();
                    int available_bikes = Int32.Parse(station["available_bikes"].ToString());

                    JCDecaux_data[contract_added].Add(new Station(number, contract_name, name, address, lat, lng, status, available_bikes));
                }
            }
            return "OK";
        }

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

        public double getDistance(double lat1, double lng1, double lat2, double lng2)
        {
            var R = 6371; // Radius of the earth in km
            var dLat = deg2rad(lat2 - lat1);  // deg2rad below
            var dLon = deg2rad(lng2 - lng1);
            var a =
              Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
              Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) *
              Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
              ;
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c; // Distance in km
            return d;
        }

        public double deg2rad(double deg)
        {
            return deg * (Math.PI / 180);
        }

        public List<Station> getNearestStations(Station station)
        {
            List<Station> nearests = new List<Station>();
            string station_contract_name = station.contract_name;
            foreach(Contract c in JCDecaux_data.Keys)
            {
                if(c.name == station_contract_name)
                {
                    foreach(Station s in JCDecaux_data[c])
                    {
                        if(getDistance(station.lat, station.lng, s.lat, s.lng) <= 50)
                        {
                            nearests.Add(s);
                        }
                    }
                    break;
                }
            }
            return nearests;
        }

        public Dictionary<Station, double> getNearestStations(double lat, double lng, string station_contract_name)
        {
            Dictionary<Station, double> nearests = new Dictionary<Station, double>();
            foreach (Contract c in JCDecaux_data.Keys)
            {
                if (c.name == station_contract_name)
                {
                    foreach (Station s in JCDecaux_data[c])
                    {
                        if (getDistance(lat, lng, s.lat, s.lng) <= 2)
                        {
                            nearests[s] = getDistance(lat, lng, s.lat, s.lng);
                        }
                    }
                    break;
                }
            }
            return nearests;
        }
    }

   
}
