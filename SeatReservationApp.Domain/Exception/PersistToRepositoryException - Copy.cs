using System;
using System.Runtime.Serialization;

namespace SeatReservationApp.Airplanes.Domain.Exception
{
    [Serializable]
    public class AirplaneValidationException : System.Exception
    {

        public AirplaneValidationException()
        {

        }
        public AirplaneValidationException(string message) : base(message)
        {

        }
        public AirplaneValidationException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
        protected AirplaneValidationException(SerializationInfo info,
         StreamingContext context)
            : base(info, context)
        {

        }

    }
}
