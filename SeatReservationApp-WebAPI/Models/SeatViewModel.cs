using System.ComponentModel.DataAnnotations;

namespace SeatReservationApp_WebAPI.Models
{
    public class SeatViewModel
    {
        [Required]
        public int FlightNumber;
        [Required]
        public int Column;
        [Required]
        public int Row;
    }
}