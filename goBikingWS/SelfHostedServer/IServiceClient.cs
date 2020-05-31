using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

using goBikingWSCache;
using goBikingWSSuggestion;

using System.Text;

/// <summary>
/// Description résumée de Class1
/// </summary>
/// goBikingWCFClient.ServiceClient

namespace goBikingWCFClient
{
	[ServiceContract]
	public interface IServiceClient
	{
		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "contracts",
						ResponseFormat = WebMessageFormat.Json)]
		List<Contract> loadContracts();

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "stations/{contractname}",
						ResponseFormat = WebMessageFormat.Json)]
		List<Station> loadStations(string contractname);


		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "station/{stationnumber}",
						ResponseFormat = WebMessageFormat.Json)]
		Station loadStation(string stationnumber);

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "contract/{contractname}",
						ResponseFormat = WebMessageFormat.Json)]
		Contract loadContract(string contractname);


		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "station/position/{stationnumber}",
						ResponseFormat = WebMessageFormat.Json)]
		Location loadStationPostion(string stationnumber);

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "route/{lat1}/{lng1}/{lat2}/{lng2}",
						ResponseFormat = WebMessageFormat.Json)]
		List<Location> getRoute(string lat1, string lng1, string lat2, string lng2);

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "route/{stationnumber1}/{stationnumber2}",
						ResponseFormat = WebMessageFormat.Json)]
		List<Location> getRouteFromStations(string stationnumber1, string stationnumber2);


		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "distance/{lat1}/{lng1}/{lat2}/{lng2}",
						ResponseFormat = WebMessageFormat.Json)]
		double getDistance(string lat1, string lng1, string lat2, string lng2);

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "distance/{lat}/{lng}/{station_contract_name}",
						ResponseFormat = WebMessageFormat.Json)]
		Dictionary<Station, double> getNearestStations(string lat, string lng, string station_contract_name);


		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "reviews/{place_id}",
						ResponseFormat = WebMessageFormat.Json)]
		List<Review> getReviews(string place_id);

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "nearests/{lat}/{lng}/{radius}",
						ResponseFormat = WebMessageFormat.Json)]
		List<Place> nearBySearch(string lat, string lng, string radius);

	}

}
	