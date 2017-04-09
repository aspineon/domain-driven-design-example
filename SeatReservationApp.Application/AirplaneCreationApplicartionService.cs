using System;
using SeatReservationApp.Contracts.Application;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp.Domain.DomainServicesContracts;
using SeatReservationApp.Domain.Entities;
using SeatReservationApp.Impl.Application.MapFactories;

namespace SeatReservationApp.Impl.Application
{
    public class AirplaneCreationApplicationService : IAirplaneCreationApplicationService
    {
        private readonly IAirplanePersistService _airplanePersistService;

        public AirplaneCreationApplicationService(IAirplanePersistService airplanePersistService)
        {
            _airplanePersistService = airplanePersistService;
        }
        public void CreateAirplane(AirplaneDto AirplaneDto)
        {
            try
            {
                var mapper = MappingsFactory.GetFor(EnumViewModel.MappingAirplaneEntity);
                var airplane = mapper.Get<AirplaneDto, Airplane>(AirplaneDto);
                _airplanePersistService.Persist(airplane);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
