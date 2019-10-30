using System;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    public class RestClient : IRestClient
    {
        public IRestSharpClient GetRestClient(Uri apiUrl)
        {
            return new RestSharpClient(apiUrl);
        }
    }
}
