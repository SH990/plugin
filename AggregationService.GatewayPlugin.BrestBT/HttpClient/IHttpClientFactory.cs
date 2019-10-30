using System;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    public interface IHttpClientFactory
    {
        IHttpClient Create(Uri apiUrl);
    }
}