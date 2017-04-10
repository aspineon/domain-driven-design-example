using System.Collections.Generic;
using SeatReservationApp.Airplanes.Domain.Entities;

namespace SeatReservationApp.Domain.UnitTest
{
    public class StubHelper
    {
        public static List<Seat> seatsStub = new List<Seat>
        {
            new Seat
            {
                Column = 1,
                Row = 1,
                Available = AvailabilityEnum.Booked
            },
            new Seat
            {
                Column = 1,
                Row = 2,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 2,
                Row = 1,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 2,
                Row = 2,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 3,
                Row = 1,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 3,
                Row = 2,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 4,
                Row = 1,
                Available = AvailabilityEnum.Booked
            },
            new Seat
            {
                Column = 4,
                Row = 2,
                Available = AvailabilityEnum.Booked
            }

        };
    }
}
