using SeatReservationApp.Contracts.Application.DTO;

namespace SeatReservationApp.Contracts.Application
{
    public interface ISeatAvailabilityApplicationService
    {
        bool GetSeatAvailability(SeatDto seat);
    }
}
