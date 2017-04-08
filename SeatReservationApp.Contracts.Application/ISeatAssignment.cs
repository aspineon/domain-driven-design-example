using SeatReservationApp.Contracts.Application.DTO;

namespace SeatReservationApp.Contracts.Application
{
    public interface ISeatAssignment
    {
        SeatDTO
        bool AssignSeat(SeatDTO seatDto);
        bool UnAssignSeat(SeatDTO seatDto);
    }
}
