using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace goBikingWSCache
{
    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    // Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "goBikingWCFexternal.ContractType".
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



    [DataContract]
    public class Station
    {
        public int number;
        public string contract_name;
        public string name;
        public string address;
        public double lat;
        public double lng;
        public string status;
        public int available_bikes;

        public Station(int number, string contract_name, string name, string address, double lat, double lng, string status, int available_bikes)
        {
            this.number = number;
            this.contract_name = contract_name;
            this.name = name;
            this.address = address;
            this.lat = lat;
            this.lng = lng;
            this.status = status;
            this.available_bikes = available_bikes;
        }

        [DataMember]
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        [DataMember]
        public string Contract_name
        {
            get { return contract_name; }
            set { contract_name = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [DataMember]
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        [DataMember]
        public double Lng
        {
            get { return lng; }
            set { lng = value; }
        }
        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        [DataMember]
        public int Available_bikes
        {
            get { return available_bikes; }
            set { available_bikes = value; }
        }
    }


    [DataContract]
    public class Contract
    {
        public string name;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }


    [DataContract]
    public class Location
    {
        public double latitude = 0.0;
        public double longitude = 0.0;


        public Location()
        {
            latitude = 0.0;
            longitude = 0.0;
        }

        public Location(double lat, double lng)
        {
            this.latitude = lat;
            this.longitude = lng;
        }
        [DataMember]
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        [DataMember]
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
    }
}
