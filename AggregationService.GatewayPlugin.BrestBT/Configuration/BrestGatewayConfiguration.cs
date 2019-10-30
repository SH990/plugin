using System;

namespace AggregationService.GatewayPlugin.BrestBT.Configuration
{
    public class BrestGatewayConfiguration : BaseConfigration, IBrestGatewayConfiguration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Uri ApiEndpoint { get; set; }
    }
}