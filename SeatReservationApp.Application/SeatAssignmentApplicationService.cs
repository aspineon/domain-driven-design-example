using System;
using System.Collections.Generic;
using SeatReservationApp.Contracts.Application;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp.Domain.DomainServiceImplementations;
using SeatReservationApp.Domain.Entities;

namespace SeatReservationApp.Impl.Application
{
    public class SeatAssignmentApplicationService : ISeatAssignmentApplicationService
    {
        private readonly IAssignSeatService _assignSeatService;

        public SeatAssignmentApplicationService(IAssignSeatService assignSeatService)
        {
            _assignSeatService = assignSeatService;
        }
        public bool AssignSeat(AssignSeatDto seatDto)
        {
            var airplane = new Airplane(seatDto.FlightNumber, new List<Seat>(), 0, 0);
            var seat = new Seat {Row = seatDto.Row, Column = seatDto.Column};
            return _assignSeatService.AssignSeat(airplane, seat);
        }

        public bool UnAssignSeat(AssignSeatDto seatDto)
        {
            throw new NotImplementedException();
        }
    }
}
