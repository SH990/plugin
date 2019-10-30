using AggregationService.GatewayPlugin.BrestBT.Configuration;
using AggregationService.GatewayPlugin.BrestBT.HttpClient.ResponseModel;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    interface IBrestBTClient
    {
        BrestBTResponse GetTicketBooking(UserBookingOptions bookingOptions, IBrestGatewayConfiguration brestGatewayConfiguration);
    }
}
