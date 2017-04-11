namespace SeatReservationApp.Management.Infrastructure.QueriesConstants
{
    public class QueriesConstants
    {
        public const string InsertIntoBookingSeats =
            @"INSERT INTO dbo.[BookingSeats] VALUES (@Column, @Row) SELECT SCOPE_IDENTITY()";

        public const string InsertIntoUsers = 
            @"INSERT INTO dbo.[User] (FirstName, LastName, PostalCode, Address, Country, City, Telephone) VALUES (@FirstName, @LastName, @PostalCode, @Address, @Country, @City, @Telephone) SELECT SCOPE_IDENTITY()";

        public const string InsertIntoBooking =
            @"INSERT INTO dbo.[Booking] (SeatId, Arrival, Departure, UserId) VALUES(@SeatId, @Arrival, @Departure, @UserId) SELECT SCOPE_IDENTITY()";


    }
}
