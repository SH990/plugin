using System;
using System.Runtime.Serialization;

namespace AggregationService.GatewayPlugin.BrestBT.Exceptions
{
    [Serializable]
    public class BrestBTApiException : Exception
    {
        public BrestBTApiException(string userName, string errorDescription)
            : base($"Ticket booking for user {userName} was failed with error description: {errorDescription}")
        {}

        protected BrestBTApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {}
    }
}
