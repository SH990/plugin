using System;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    public interface IRestClient
    {
        IRestSharpClient GetRestSharpClient(Uri apiUrl);
    }
}