using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeatReservationApp.Management.Domain.Entities;
using SeatReservationApp.Management.Infrastructure.Repository;
using Seat = SeatReservationApp.Management.Infrastructure.Persistence_Models.Seat;
using User = SeatReservationApp.Management.Infrastructure.Persistence_Models.User;

namespace SeatReservationApp.Management.Infrastructure.IntegTest
{
    [TestClass]
    public class BookingRepositorySpec
    {
        [TestMethod]
        public void Insert_succesfully_a_booking_into_database()
        {
            var repository = new BookingRepository();
            repository.InsertNewBooking(new Booking
            {
                Seat = new Domain.Entities.Seat
                {
                    Column = 2,
                    Row = 1
                },
                Arrival = new DateTime(2017, 1, 18, 11, 15, 0),
                Departure = new DateTime(2017, 1, 18, 10, 15, 0),
                User = new Domain.Entities.User
                {
                    FirstName = "John",
                    LastName = "Ahmes",
                    Telephone = "333445566",
                    Address = new UserAddress
                    {
                        Address = "Baker Street",
                        City = "BCN",
                        Country = "Spain",
                        PostalCode = "55599"
                    }
                }
            });
        }
    }
}
