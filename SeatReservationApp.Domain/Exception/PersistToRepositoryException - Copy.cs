using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SeatReservationApp.Domain.Exception
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
