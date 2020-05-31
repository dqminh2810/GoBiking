﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using goBikingWSCache;

namespace goBikingWSRoute
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceGoogleMap
    {
        [OperationContract]
        string GetData(int value);


        [OperationContract]
        List<Location> getRoute(string lat1, string long1, string lat2, string long2);
    }
}
