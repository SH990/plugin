using System.Threading.Tasks;
using AggregationService.GatewayPlugin.BrestBT.Configuration;
using AggregationService.GatewayPlugin.BrestBT.HttpClient;

namespace AggregationService.GatewayPlugin.BrestBT
{
    public class BrestBTGateway : BaseGateway
    {
        private readonly IBrestBTClient _brestBTClient;
        private readonly IConfigurationProvider _configurationProvider;
        public BrestBTGateway(IPrinterService printerService,
            IBrestBTClient brestBTClient,
            IConfigurationProvider configurationProvider)
            : base(printerService)
        {
            _brestBTClient = brestBTClient;
            _configurationProvider = configurationProvider;
        }

        public override async Task<TicketBooking> BookTicket(UserBookingOptions userBookingOptions)
        {
            var userConfiguration =
                _configurationProvider.GetApiConfiguration<IBrestGatewayConfiguration>(userBookingOptions.UserId);

            var ticketBooking = await _brestBTClient.GetTicketBooking(userBookingOptions, userConfiguration);

            return new TicketBooking
            {
                TicketNumber = ticketBooking.TicketNumber,
                Seat = ticketBooking.SeatNumber,
                BusNumber = ticketBooking.BusNumber
            };
        }
    }
}
