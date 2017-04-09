using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeatReservationApp_WebAPI.Models
{
    public class SeatsCreationViewModel
    {
        [Required] public string Column;
        [Required] public string Row;
    }
}