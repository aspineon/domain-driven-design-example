using SeatReservationApp.Domain.Entities;

namespace SeatReservationApp.Domain.DomainServiceImplementations
{
    public interface IAssignSeatService
    {
        bool AssignSeat(Airplane airplane, Seat seat);
    }
}