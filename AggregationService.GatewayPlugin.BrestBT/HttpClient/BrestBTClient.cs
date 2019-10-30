using System.Threading.Tasks;
using AggregationService.GatewayPlugin.BrestBT.Configuration;
using AggregationService.GatewayPlugin.BrestBT.Exceptions;
using AggregationService.GatewayPlugin.BrestBT.HttpClient.RequestModel;
using AggregationService.GatewayPlugin.BrestBT.HttpClient.ResponseModel;

namespace AggregationService.GatewayPlugin.BrestBT.HttpClient
{
    public class BrestBTClient : IBrestBTClient
    {
        private readonly IRestClient _restClient;

        public BrestBTClient(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<BrestBTResponse> GetTicketBooking(UserBookingOptions bookingOptions, IBrestGatewayConfiguration brestGatewayConfiguration)
        {
            var request = CreateApiRequest(bookingOptions);
            var client = _restClient.GetRestSharpClient(brestGatewayConfiguration.ApiEndpoint);

            var response = await client.GetResponseAsync<BrestBTResponse>(request);
            if (!IsResponseSuccessful(response))
            {
                throw new BrestBTApiException(brestGatewayConfiguration.Username, response.ErrorStatus.Error);
            }

            return response;
        }

        private BrestBTRequest CreateApiRequest(UserBookingOptions bookingOptions)
        {
            return new BrestBTRequest
            {
                BookingTime = bookingOptions.UserBookingTime
            };
        }

        private static bool IsResponseSuccessful(BrestBTResponse response)
        {
            return !string.IsNullOrEmpty(response.ErrorStatus.ErrorDescription);
        }
    }
}
