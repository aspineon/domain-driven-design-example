using SeatReservationApp.Contracts.Application.DTO;

namespace SeatReservationApp.Contracts.Application
{
    public interface ISeatAssignmentApplicationService
    {
        bool AssignSeat(AssignSeatDto seatDto);
        bool UnAssignSeat(AssignSeatDto seatDto);
    }
}
