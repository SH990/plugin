using System;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    class HttpClientFactory : IHttpClientFactory
    {
        public IHttpClient Create(Uri apiUrl)
        {
            return new RestSharpHttpClient(apiUrl);
        }
    }
}
