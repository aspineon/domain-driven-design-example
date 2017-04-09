using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SeatReservationApp.Contracts.Application;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp_WebAPI.MapFactories;
using SeatReservationApp_WebAPI.Models;

namespace SeatReservationApp_WebAPI.Controllers
{
    [Route("api/seats")]
    public class SeatReservationController : ApiController
    {
        private readonly ISeatAssignmentApplicationService _seatAssignment;

        public SeatReservationController(ISeatAssignmentApplicationService seatAssignment)
        {
            _seatAssignment = seatAssignment;
        }

        [Route("api/seats/assign")]
        [HttpPost]
        public IHttpActionResult AssignSeat([FromBody]SeatViewModel seatVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var mapper = MappingsFactory.GetFor(EnumViewModel.SeatViewModel);
                    var seatDto = mapper.Get<SeatViewModel, SeatDTO>(seatVm);
                    return Ok(_seatAssignment.AssignSeat(seatDto));
                }
                return BadRequest(ModelState);
            }
            catch (Exception e)
            {
                return BadRequest("Error assigning seat");
            }
        }

    }
}
