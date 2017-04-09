using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeatReservationApp_WebAPI.Models
{
    public class AirplaneCreationViewModel
    {
        [Required]
        public int FlightNumber;

        [Required]
        public List<SeatsCreationViewModel> Seats;
    }
}