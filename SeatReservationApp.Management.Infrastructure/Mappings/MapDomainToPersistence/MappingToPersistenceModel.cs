using SeatReservationApp.Management.Infrastructure.Persistence_Models;
using Booking = SeatReservationApp.Management.Domain.Entities.Booking;

namespace SeatReservationApp.Management.Infrastructure.Mappings.MapDomainToPersistence
{
    internal class MappingToPersistenceModel : MappingBase
    {
        internal override TOutput Get<TInput, TOutput>(TInput source)
        {
            if (source == null) { return default(TOutput); }

            var model = source as Booking;

            return new Persistence_Models.Booking
            {
                Seat = new Seat
                {
                    Column = model.Seat.Column,
                    Row = model.Seat.Row
                },
                Arrival = model.Arrival,
                Departure = model.Departure,
                User = new User
                {
                    Address =  model.User.Address.Address,
                    City =  model.User.Address.City,
                    Country = model.User.Address.Country,
                    PostalCode = model.User.Address.PostalCode,
                    FirstName = model.User.FirstName,
                    LastName = model.User.LastName,
                    Telephone = model.User.Telephone
                }
            } as TOutput;
        }
    }
}