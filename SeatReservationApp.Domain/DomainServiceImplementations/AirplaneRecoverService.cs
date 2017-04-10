using System.Linq;
using SeatReservationApp.Airplanes.Domain.DomainServicesContracts;
using SeatReservationApp.Airplanes.Domain.Entities;
using SeatReservationApp.Airplanes.Domain.Repository;

namespace SeatReservationApp.Airplanes.Domain.DomainServiceImplementations
{
    public class AirplaneRecoverService : IAirplaneRecoverService
    {
        private readonly IAirplaneRepository _repository;

        public AirplaneRecoverService(IAirplaneRepository repository)
        {
            _repository = repository;
        }
        public Airplane RecoverPlane(Airplane airplane)
        {
           return _repository.FindBy(x => x.Id == airplane.Id, x => x.Seats).SingleOrDefault();
        }
    }
}
