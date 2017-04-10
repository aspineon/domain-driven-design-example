using SeatReservationApp.Airplanes.Domain.DomainServicesContracts;
using SeatReservationApp.Airplanes.Domain.Entities;
using SeatReservationApp.Airplanes.Domain.Repository;

namespace SeatReservationApp.Airplanes.Domain.DomainServiceImplementations
{
    public class AssignSeatService : IAssignSeatService
    {
        private readonly IAirplaneRepository _airplaneRepository;
        private readonly IAirplaneRecoverService _airplaneRecoverService;

        public AssignSeatService(IAirplaneRepository airplaneRepository, IAirplaneRecoverService airplaneRecoverService)
        {
            _airplaneRepository = airplaneRepository;
            _airplaneRecoverService = airplaneRecoverService;
        }


        public bool AssignSeat(Airplane airplane, Seat seat)
        {
            var airplaneSelected = _airplaneRecoverService.RecoverPlane(airplane);
            if (airplaneSelected.IsValidAirplane())
            {
                if (airplaneSelected.CanAssignSeat(seat))
                {
                    airplaneSelected.Seats.Find(x => x.Row == seat.Row && x.Column == seat.Column).Available = AvailabilityEnum.Booked;
                    _airplaneRepository.Edit(airplaneSelected);
                    _airplaneRepository.Save();
                    return true;
                }
            }
            return false;
        }

    }
}
