using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using goBikingWSCache;
namespace goBikingWSSuggestion
{
    [DataContract]
    public class Place
    {
        string id;
        string name;
        string address;
        Location location;
        Boolean isOpen;
        double rating;
        List<Review> reviews;

        public Place(string id, string name, string address, Location location, bool isOpen, double rating, List<Review> reviews)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Location = location;
            this.IsOpen = isOpen;
            this.Rating = rating;
            this.reviews = reviews;
        }

        public Place(string id, string name, string address, Location location, double rating)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Location = location;
            this.isOpen = true;
            this.Rating = rating;
            this.reviews = new List<Review>();
        }
        [DataMember]
        public string Id { get => id; set => id = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public string Address { get => address; set => address = value; }
        [DataMember]
        public Location Location { get => location; set => location = value; }
        [DataMember]
        public bool IsOpen { get => isOpen; set => isOpen = value; }
        public double Rating { get => rating; set => rating = value; }
        [DataMember]
        internal List<Review> Reviews { get => reviews; set => reviews = value; }
    }

    [DataContract]
    public class Review
    {
        string author;
        string content;
        double rating;
        string time_description;

        public Review(string author, string content, double rating, string time_description)
        {
            this.Author = author;
            this.Content = content;
            this.Rating = rating;
            this.Time_description = time_description;
        }

        [DataMember]
        public string Author { get => author; set => author = value; }
        [DataMember]
        public string Content { get => content; set => content = value; }
        [DataMember]
        public double Rating { get => rating; set => rating = value; }
        [DataMember]
        public string Time_description { get => time_description; set => time_description = value; }
    }
}
