using SeatReservationApp.Airplanes.Domain.Entities;

namespace SeatReservationApp.Airplanes.Domain.DomainServicesContracts
{
    public interface IAirplanePersistService
    {
        void Persist(Airplane airplane);
    }
}