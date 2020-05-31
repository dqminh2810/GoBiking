using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace goBikingWSSuggestion
{
    [ServiceContract]
    public interface IServiceSuggestion
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Review> getReviews(string place_id);

        [OperationContract]
        List<Place> nearBySearch(string lat, string lng, int radius);
    }
}
