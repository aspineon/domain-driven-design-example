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
    public class AirplaneCreationController : ApiController
    {
        private readonly IAirplaneCreationApplicationService _airplaneCreation;

        public AirplaneCreationController(IAirplaneCreationApplicationService airplaneCreation)
        {
            _airplaneCreation = airplaneCreation;
        }

        [Route("api/airplane/create")]
        [HttpPost]
        public IHttpActionResult AssignSeat([FromBody]AirplaneCreationViewModel airplaneVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var mapper = MappingsFactory.GetFor(EnumViewModel.AirplaneDto);
                    var airplaneDto = mapper.Get<AirplaneCreationViewModel, AirplaneDto>(airplaneVm);
                    _airplaneCreation.CreateAirplane(airplaneDto);
                    return Ok();
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
