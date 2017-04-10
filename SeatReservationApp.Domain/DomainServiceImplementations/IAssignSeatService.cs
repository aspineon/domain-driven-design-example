using SeatReservationApp.Airplanes.Domain.Entities;

namespace SeatReservationApp.Airplanes.Domain.DomainServiceImplementations
{
    public interface IAssignSeatService
    {
        bool AssignSeat(Airplane airplane, Seat seat);
    }
}