using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using goBikingWSCache;
namespace goBikingWSRoute
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class ServiceGoogleMap : IServiceGoogleMap
    {

        public static string responseFromServer = "Loading...";
        public static string APIKey = "AIzaSyBErIMAEFidxYKC1HAch9oUQS3TAubMYQ8";

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public static String getDirection(string lat1, string long1, string lat2, string long2)
        {
            Console.WriteLine("inside");
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
            "https://maps.googleapis.com/maps/api/directions/json?origin="+lat1+","+long1+"&destination="+lat2+","+long2+"&key="
            + APIKey);
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


		//OPERATION CONTRACT IMPLEMENTATION
		public List<Location> getRoute(string lat1, string long1, string lat2, string long2)
		{
			string polyline = getPolyLine(lat1, long1, lat2, long2);
			List<Location> points = new List<Location>();
			points = decodePolyline(polyline);
			//JArray Jpoints = (JArray)JToken.FromObject(points);
			return points;
		}



		public static string getPolyLine(string lat1, string long1, string lat2, string long2)
		{
			string polylineValue = "";
			string res = getDirection(lat1, long1, lat2, long2);
			JObject items = JObject.Parse(res);

			JArray routes = (JArray)items["routes"];
			foreach (JObject item in routes)
			{
				polylineValue = item["overview_polyline"]["points"].ToString();
				//contractListBox.Items.Add(contract["name"].ToString());
			}
			return polylineValue;
		}

		public static List<Location> decodePolyline(string encodedPoints)
		{
			if (encodedPoints == null || encodedPoints == "") return null;
			List<Location> poly = new List<Location>();
			char[] polylinechars = encodedPoints.ToCharArray();
			int index = 0;

			int currentLat = 0;
			int currentLng = 0;
			int next5bits;
			int sum;
			int shifter;

			try
			{
				while (index < polylinechars.Length)
				{
					// calculate next latitude
					sum = 0;
					shifter = 0;
					do
					{
						next5bits = (int)polylinechars[index++] - 63;
						sum |= (next5bits & 31) << shifter;
						shifter += 5;
					} while (next5bits >= 32 && index < polylinechars.Length);

					if (index >= polylinechars.Length)
						break;

					currentLat += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

					//calculate next longitude
					sum = 0;
					shifter = 0;
					do
					{
						next5bits = (int)polylinechars[index++] - 63;
						sum |= (next5bits & 31) << shifter;
						shifter += 5;
					} while (next5bits >= 32 && index < polylinechars.Length);

					if (index >= polylinechars.Length && next5bits >= 32)
						break;

					currentLng += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);
					Location p = new Location();
					p.Latitude = Convert.ToDouble(currentLat) / 100000.0;
					p.Longitude = Convert.ToDouble(currentLng) / 100000.0;
					poly.Add(p);
				}
			}
			catch (Exception ex)
			{
				// logo it
			}
			return poly;
		}
	}
}
