using System;
using System.Runtime.Serialization;

namespace AggregationService.GatewayPlugin.BrestBT.Exceptions
{
    [Serializable]
    public class BrestBTApiException : Exception
    {
        public BrestBTApiException(string UserName, string errorCode, string errorDescription)
            : base($"Ticket booking for user {UserName} was failed with error description: {errorDescription}");

        protected BrestBTApiException(SerializationInfo info, StreamingContext context)
            : base(info, context);
    }
}
