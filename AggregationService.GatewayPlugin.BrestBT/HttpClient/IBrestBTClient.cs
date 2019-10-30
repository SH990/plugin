using System.Threading.Tasks;
using AggregationService.GatewayPlugin.BrestBT.Configuration;
using AggregationService.GatewayPlugin.BrestBT.HttpClient.ResponseModel;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    public interface IBrestBTClient
    {
        Task<BrestBTResponse> GetTicketBooking(UserBookingOptions bookingOptions, IBrestGatewayConfiguration brestGatewayConfiguration);
    }
}
