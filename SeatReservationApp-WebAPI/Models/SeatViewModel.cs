using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeatReservationApp_WebAPI.Models
{
    public class SeatViewModel
    {
        [Required]
        public int Column;
        [Required]
        public int Row;
    }
}