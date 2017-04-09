using System.Linq;
using System.Runtime.Remoting.Messaging;
using SeatReservationApp.Domain.DomainServicesContracts;
using SeatReservationApp.Domain.Entities;
using SeatReservationApp.Domain.Repository;

namespace SeatReservationApp.Domain.DomainServiceImplementations
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
           return _repository.FindBy(x => x.Id == airplane.Id, x => x.Seats).SingleOrDefault() ;
        }
    }
}
