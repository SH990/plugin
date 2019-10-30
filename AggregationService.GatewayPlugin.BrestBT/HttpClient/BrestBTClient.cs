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
            _restClient = restClient
        }

        public BrestBTResponse GetTicketBooking(UserBookingOptions bookingOptions, IBrestGatewayConfiguration brestGatewayConfiguration)
        {
            var request = CreateApiRequest(bookingOptions);
            var сlient = _restClient.GetRestClient(brestGatewayConfiguration.ApiEndpoint);

            var response = сlient.GetResponse<BrestBTResponse>(request);
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

        private bool IsResponseSuccessful(BrestBTResponse response)
        {
            return !string.IsNullOrEmpty(response.ErrorStatus.ErrorDescription);
        }
    }
}
