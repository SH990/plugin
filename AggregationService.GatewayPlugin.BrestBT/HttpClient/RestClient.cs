using System;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    public class RestClient : IRestClient
    {
        public IRestSharpClient GetRestSharpClient(Uri apiUrl)
        {
            return new RestSharpClient(apiUrl);
        }
    }
}
