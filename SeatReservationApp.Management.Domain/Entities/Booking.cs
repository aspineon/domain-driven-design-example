using System;

namespace SeatReservationApp.Management.Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public Seat Seat { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        protected User User { get; set;  }

        public User GetBookingCreator()
        {
            return User;
        }

        public TimeSpan GetFlightDuration()
        {
            return CheckTimeBetweenDepartureAndArrival();
        }

        private TimeSpan CheckTimeBetweenDepartureAndArrival()
        {
            return Arrival - Departure;
        }

        public bool IsValidDepartureAndArrival()
        {
            var time = Arrival - Departure;
            return time.TotalMinutes > 0;
        }

    }


}
