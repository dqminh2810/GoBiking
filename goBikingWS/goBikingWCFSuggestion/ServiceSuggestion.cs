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

namespace goBikingWSSuggestion
{
    public class ServiceSuggestion: IServiceSuggestion
    {

        public static string responseFromServer = "Loading...";
        public static string APIKey = "AIzaSyBErIMAEFidxYKC1HAch9oUQS3TAubMYQ8";
        //public static Dictionary<Contract, List<Station>> JCDecaux_data = new Dictionary<Contract, List<Station>>();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public List<Review> getReviews(string place_id)
        {
            List<Review> res = new List<Review>();

            string res_details = getPlaceDetails(place_id);
            JObject details = JObject.Parse(res_details);

            if(details["status"].ToString()=="OK")
            {
                JArray reviews = (JArray)details["result"]["reviews"];
                if(reviews != null)
                {
                    foreach (JObject r in reviews)
                    {
                        string author = r["author_name"].ToString();
                        string content = r["text"].ToString();
                        double rating = Double.Parse(r["rating"].ToString());
                        string time_description = r["relative_time_description"].ToString();
                        res.Add(new Review(author, content, rating, time_description));
                    }
                }
            }
            return res;
        }

        public List<Place> nearBySearch(string lat, string lng, int radius)
        {
            List<Place> res = new List<Place>();
            radius = 1500;
            string res_suggestions = nearBySearchWithRadius(lat, lng, radius.ToString()); ;
            JObject response = JObject.Parse(res_suggestions);
            JArray result = (JArray) response["results"];
            foreach (JObject place in result)
            {
                string place_id = place["place_id"].ToString();                
                string place_name = place["name"].ToString();                
                string place_address = place["vicinity"].ToString();
                double place_lat = Convert.ToDouble(place["geometry"]["location"]["lat"]);
                double place_lng = Convert.ToDouble(place["geometry"]["location"]["lng"]);
                Location place_location = new Location(place_lat, place_lng);                
                //Boolean place_isOpen = Convert.ToBoolean(place["opening_hours"]["open_now"]);
                double place_rating = Convert.ToDouble(place["rating"]);
                List<Review> place_reviews = getReviews(place_id);
                if(place_reviews.Count == 0)
                {
                    res.Add(new Place(place_id, place_name, place_address, place_location, place_rating));
                }else
                {
                    res.Add(new Place(place_id, place_name, place_address, place_location, true, place_rating, place_reviews));
                }
            }
            return res;
        }

        public static string nearBySearchWithRadius(string lat, string lng, string radius)
        {
            Console.WriteLine("inside");
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
            "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location="+lat+","+lng+"&radius=1500&type=point_of_interest&key="+ APIKey);
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

        public static string getPlaceDetails(string place_id)
        {
            Console.WriteLine("inside");
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
                "https://maps.googleapis.com/maps/api/place/details/json?place_id=" + place_id + "&fields=name,rating,reviews&key=" + APIKey);
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
    }
}
