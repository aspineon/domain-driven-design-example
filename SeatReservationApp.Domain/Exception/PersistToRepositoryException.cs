using System;
using System.Runtime.Serialization;

namespace SeatReservationApp.Airplanes.Domain.Exception
{
    [Serializable]
    public class PersistToRepositoryException : System.Exception
    {

        public PersistToRepositoryException()
        {

        }
        public PersistToRepositoryException(string message) : base(message)
        {

        }
        public PersistToRepositoryException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
        protected PersistToRepositoryException(SerializationInfo info,
         StreamingContext context)
            : base(info, context)
        {

        }

    }
}
