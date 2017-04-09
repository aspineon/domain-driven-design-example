using SeatReservationApp.Domain.Entities;

namespace SeatReservationApp.Domain.DomainServicesContracts
{
    public interface IAirplanePersistService
    {
        void Persist(Airplane airplane);
    }
}