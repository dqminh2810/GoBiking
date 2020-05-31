using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using goBikingWSCache;
using goBikingWSRoute;
using goBikingWSSuggestion;
/// <summary>
/// Description résumée de Class2
/// </summary>

namespace goBikingWCFClient
{
	public class ServiceClient : IServiceClient
	{
		ServiceJCDecaux serviceJCDecaux = new ServiceJCDecaux();
		ServiceGoogleMap serviceGoogleMap = new ServiceGoogleMap();
		ServiceSuggestion serviceSuggestion = new ServiceSuggestion();

		//OPERATION CONTRACT IMPLEMENTATION
		public List<Contract> loadContracts()
		{
			return serviceJCDecaux.getContractsList();
		}

		public List<Station> loadStations(string contractName)
		{
			return serviceJCDecaux.getStationsList(contractName);
		}

		public Contract loadContract(string contractName)
		{
			return serviceJCDecaux.getContract(contractName);
		}

		public Station loadStation(string number)
		{
			return serviceJCDecaux.getStation(Int32.Parse(number));
		}

		public Location loadStationPostion(string number)
		{
			return serviceJCDecaux.getStationLocation(Int32.Parse(number));
		}

		public List<Location> getRoute(string lat1, string lng1, string lat2, string lng2)
		{
			return serviceGoogleMap.getRoute(lat1, lng1, lat2, lng2);
		}

		public List<Location> getRouteFromStations(string stationNum1, string stationNum2)
		{
			string lat1 = serviceJCDecaux.getStation(Int32.Parse(stationNum1)).lat.ToString();
			string lng1 = serviceJCDecaux.getStation(Int32.Parse(stationNum1)).lng.ToString();
			string lat2 = serviceJCDecaux.getStation(Int32.Parse(stationNum2)).lat.ToString();
			string lng2 = serviceJCDecaux.getStation(Int32.Parse(stationNum2)).lng.ToString();
			return serviceGoogleMap.getRoute(lat1, lng1, lat2, lng2);
		}

		public static string refreshData()
		{
			return ServiceJCDecaux.refreshData();
		}

		public double getDistance(string lat1, string lng1, string lat2, string lng2)
		{
			return serviceJCDecaux.getDistance(Convert.ToDouble(lat1), Convert.ToDouble(lng1), Convert.ToDouble(lat2), Convert.ToDouble(lng2));
		}

		public Dictionary<Station, double> getNearestStations(string lat, string lng, string station_contract_name)
		{
			return serviceJCDecaux.getNearestStations(Convert.ToDouble(lat), Convert.ToDouble(lng), station_contract_name);
		}

		public List<Review> getReviews(string place_id)
		{
			return serviceSuggestion.getReviews(place_id);
		}

		public List<Place> nearBySearch(string lat, string lng, string radius)
		{
			return serviceSuggestion.nearBySearch(lat, lng, Int32.Parse(radius));
		}
	}
}
