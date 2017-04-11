using System;

namespace SeatReservationApp.Management.Infrastructure.Persistence_Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Seat Seat { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public User User { get; set; }
    }
}
