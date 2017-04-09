using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SeatReservationApp.Domain.Exception
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
