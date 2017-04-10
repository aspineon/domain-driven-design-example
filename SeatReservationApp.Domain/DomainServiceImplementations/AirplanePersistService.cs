using SeatReservationApp.Airplanes.Domain.DomainServicesContracts;
using SeatReservationApp.Airplanes.Domain.Entities;
using SeatReservationApp.Airplanes.Domain.Exception;
using SeatReservationApp.Airplanes.Domain.Repository;

namespace SeatReservationApp.Airplanes.Domain.DomainServiceImplementations
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
