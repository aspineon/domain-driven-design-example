using SeatReservationApp.Airplanes.Domain.Entities;

namespace SeatReservationApp.Airplanes.Domain.DomainServicesContracts
{
    public interface IAirplaneRecoverService
    {
        Airplane RecoverPlane(Airplane airplane);
    }
}