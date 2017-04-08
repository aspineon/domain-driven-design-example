using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeatReservationApp.Domain.Entities;

namespace SeatReservationApp.Domain.UniTest
{
    [TestClass]
    public class AirplanSpecs
    {
        [TestMethod]
        public void Assign_already_booked_seat()
        {
            var airplane = new Airplane(1, StubHelper.seatsStub, 4, 4);
            var assign = airplane.AssignSeat(new Seat {Column = 4, Row = 2});
            Assert.AreEqual(assign, false);
        }

        [TestMethod]
        public void Assign_free_seat()
        {
            var airplane = new Airplane(1, StubHelper.seatsStub, 4, 4);
            var assign = airplane.AssignSeat(new Seat { Column = 2, Row = 2 });
            Assert.AreEqual(assign, true);
        }

        [TestMethod]
        public void Assign_seat_out_of_range()
        {
            var airplane = new Airplane(1, StubHelper.seatsStub, 4, 4);
            var assign = airplane.AssignSeat(new Seat { Column = 5, Row = 2 });
            Assert.AreEqual(assign, false);
        }

        [TestMethod]
        public void UnAssign_booked_seat()
        {
            var airplane = new Airplane(1, StubHelper.seatsStub, 4, 4);
            var unassign = airplane.UnAssignSeat(new Seat { Column = 4, Row = 2 });
            Assert.AreEqual(unassign, true);
        }

        [TestMethod]
        public void UnAssign__seat_out_of_range()
        {
            var airplane = new Airplane(1, StubHelper.seatsStub, 4, 4);
            var assign = airplane.UnAssignSeat(new Seat { Column = 9, Row = 2 });
            Assert.AreEqual(assign, false);
        }

        [TestMethod]
        public void EnoughAvailableSeats_returns_true()
        {
            var airplane = new Airplane(1, StubHelper.seatsStub, 4, 4);
            var enoughseats = airplane.EnoughAvalaibleSeats(2);
            Assert.AreEqual(enoughseats, true);
        }

        [TestMethod]
        public void EnoughAvailableSeats_returns_false()
        {
            var airplane = new Airplane(1, StubHelper.seatsStub, 4, 4);
            var enoughseats = airplane.EnoughAvalaibleSeats(20);
            Assert.AreEqual(enoughseats, false);
        }
    }
}
