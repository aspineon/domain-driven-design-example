using System.Collections.Generic;

namespace SeatReservationApp.Contracts.Application.DTO
{
    public class AirplaneDto
    {
        public string FlightNumber;
        public List<SeatDto> Seats;
    }
}
