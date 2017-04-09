using SeatReservationApp.Contracts.Application.DTO;

namespace SeatReservationApp.Contracts.Application
{
    public interface ISeatAssignmentApplicationService
    {
        bool AssignSeat(SeatDTO seatDto);
        bool UnAssignSeat(SeatDTO seatDto);
    }
}
