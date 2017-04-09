using System;
using SeatReservationApp.Contracts.Application;
using SeatReservationApp.Contracts.Application.DTO;

namespace SeatReservationApp.Impl.Application
{
    public class SeatAssignmentApplicationService : ISeatAssignmentApplicationService
    {
        public bool AssignSeat(SeatDTO seatDto)
        {
            throw  new NotImplementedException();
        }

        public bool UnAssignSeat(SeatDTO seatDto)
        {
            throw new NotImplementedException();
        }
    }
}
