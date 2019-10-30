namespace AggregationService.GatewayPlugin.BrestBT.HttpClient.ResponseModel
{
    public class BrestBTResponse
    {
        public int TicketNumber { get; set; }
        public int BusNumber { get; set; }
        public int SeatNumber { get; set; }
        public Error ErrorStatus { get; set; }
    }
}