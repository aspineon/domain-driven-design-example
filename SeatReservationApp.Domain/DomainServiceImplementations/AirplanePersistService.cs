using SeatReservationApp.Domain.DomainServicesContracts;
using SeatReservationApp.Domain.Entities;
using SeatReservationApp.Domain.Exception;
using SeatReservationApp.Domain.Repository;

namespace SeatReservationApp.Domain.DomainServiceImplementations
{
    public class AirplanePersistService : IAirplanePersistService
    {
        private readonly IAirplaneRepository _airplaneRepository;

        public AirplanePersistService(IAirplaneRepository airplaneRepository)
        {
            _airplaneRepository = airplaneRepository;
        }

        public void Persist(Airplane airplane)
        {
            if (!airplane.IsValidAirplane())
                throw new AirplaneValidationException();            
            _airplaneRepository.Add(airplane);
            _airplaneRepository.Save();
            
        }
    }
}
