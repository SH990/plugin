using System;

namespace AggregationService.GatewayPlugin.BrestBT.Configuration
{
    public interface IBrestGatewayConfiguration
    {
        string Username { get; set; }

        string Password { get; set; }

        Uri ApiEndpoint { get; set; }
    }
}