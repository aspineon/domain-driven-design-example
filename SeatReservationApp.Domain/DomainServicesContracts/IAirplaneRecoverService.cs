using SeatReservationApp.Domain.Entities;

namespace SeatReservationApp.Domain.DomainServicesContracts
{
    public interface IAirplaneRecoverService
    {
        Airplane RecoverPlane(Airplane airplane);
    }
}