using System.Data.Entity;
using SeatReservationApp.Airplanes.Domain.Entities;
using SeatReservationApp.Airplanes.Domain.Repository;
using SeatReservationApp.Infrastructure.Context;

namespace SeatReservationApp.Infrastructure.Repository
{
    public class AirplaneRepository: GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(AirplaneContext context) : base(context){ }

        public override void Edit(Airplane entity)
        {
            _DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            foreach (var seat in entity.Seats)
            {
               Context.Entry(seat).State = EntityState.Modified;
            }
        }
    }
}
