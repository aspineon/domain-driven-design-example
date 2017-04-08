using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SeatReservationApp.Contracts.Application;
using SeatReservationApp_WebAPI.Models;

namespace SeatReservationApp_WebAPI.Controllers
{
    [Route("api/seats")]
    public class SeatReservationController : ApiController
    {
        private readonly ISeatAssignment _seatAssignment;

        public SeatReservationController(ISeatAssignment seatAssignment)
        {
            _seatAssignment = seatAssignment;
        }    
        public IHttpActionResult Get([FromUri] SeatViewModel seatVm)
        {
            if (ModelState.IsValid)
            {
                _seatAssignment.
            }
            return BadRequest(ModelState);

        }

    }
}
