using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace goBikingWSCache
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceJCDecaux
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: ajoutez vos opérations de service ici
        [OperationContract]
        List<Station> getStationsList(String contractName);

        [OperationContract]
        List<Contract> getContractsList();

        [OperationContract]
        Station getStation(int number);

        [OperationContract]
        Location getStationLocation(int number);

        [OperationContract]
        Contract getContract(string name);

        [OperationContract]
        string updateData();

        [OperationContract]
        double getDistance(double lat1, double lng1, double lat2, double lng2);

        [OperationContract]
        Dictionary<Station, double> getNearestStations(double lat, double lng, string station_contract_name);

    }
}
