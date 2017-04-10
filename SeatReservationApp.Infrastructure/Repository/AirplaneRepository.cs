using SeatReservationApp.Airplanes.Domain.Entities;
using SeatReservationApp.Airplanes.Domain.Repository;
using SeatReservationApp.Infrastructure.Context;

namespace SeatReservationApp.Infrastructure.Repository
{
    public class AirplaneRepository: GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(AirplaneContext context) : base(context){ }
    }
}
