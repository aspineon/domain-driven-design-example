using SeatReservationApp.Contracts.Application.DTO;

namespace SeatReservationApp.Contracts.Application
{
    public interface IAirplaneCreationApplicationService
    {
        void CreateAirplane(AirplaneDto AirplaneDto);    
    }
}
