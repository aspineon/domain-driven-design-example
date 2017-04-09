using SeatReservationApp.Domain.Repository;
using SeatReservationApp.Infrastructure.Context;

namespace SeatReservationApp.Infrastructure.Repository
{
    public class AirplaneRepository: GenericRepository<Domain.Entities.Airplane>, IAirplaneRepository
    {
  
        public AirplaneRepository(AirplaneContext context) : base(context)
        {
        }
    }
}
