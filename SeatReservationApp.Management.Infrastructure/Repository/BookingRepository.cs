using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using SeatReservationApp.Management.Infrastructure.Mappings;
using Booking = SeatReservationApp.Management.Domain.Entities.Booking;

namespace SeatReservationApp.Management.Infrastructure.Repository
{
    public class BookingRepository
    {
        public void InsertNewBooking(Booking booking)
        {
            var mappingFactory = Mappings.MappingsFactory.GetFor(EnumMappingModel.ToPersistenceModel);
            var persistenceModel = mappingFactory.Get<Booking, Persistence_Models.Booking>(booking);

            using (var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SeatReservationApp.Database;Integrated Security=True"))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var insertUserCommand = new SqlCommand
                        {
                            Connection = connection,
                            CommandType = System.Data.CommandType.Text,
                            CommandText = QueriesConstants.QueriesConstants.InsertIntoUsers,
                            Transaction = transaction
                        };

                        insertUserCommand.Parameters.AddWithValue("@FirstName", persistenceModel.User.FirstName);
                        insertUserCommand.Parameters.AddWithValue("@LastName", persistenceModel.User.LastName);
                        insertUserCommand.Parameters.AddWithValue("@PostalCode", persistenceModel.User.PostalCode);
                        insertUserCommand.Parameters.AddWithValue("@Address", persistenceModel.User.Address);
                        insertUserCommand.Parameters.AddWithValue("@Country", persistenceModel.User.Country);
                        insertUserCommand.Parameters.AddWithValue("@City", persistenceModel.User.City);
                        insertUserCommand.Parameters.AddWithValue("@Telephone", persistenceModel.User.Telephone);

                        int userId = Convert.ToInt32(insertUserCommand.ExecuteScalar());

                        var insertBookingSeatCommand = new SqlCommand
                        {
                            Connection = connection,
                            CommandType = System.Data.CommandType.Text,
                            CommandText = QueriesConstants.QueriesConstants.InsertIntoBookingSeats,
                            Transaction = transaction
                        };

                        insertBookingSeatCommand.Parameters.AddWithValue("@Column", persistenceModel.Seat.Column);
                        insertBookingSeatCommand.Parameters.AddWithValue("@Row", persistenceModel.Seat.Row);

                        int seatId = Convert.ToInt32(insertBookingSeatCommand.ExecuteScalar());

                        var insertBookingCommand = new SqlCommand
                        {
                            Connection = connection,
                            CommandType = System.Data.CommandType.Text,
                            CommandText = QueriesConstants.QueriesConstants.InsertIntoBooking,
                            Transaction = transaction
                        };

                        insertBookingCommand.Parameters.AddWithValue("@SeatId", seatId);
                        insertBookingCommand.Parameters.AddWithValue("@Arrival", persistenceModel.Arrival);
                        insertBookingCommand.Parameters.AddWithValue("@Departure", persistenceModel.Departure);
                        insertBookingCommand.Parameters.AddWithValue("@UserId", userId);

                        insertBookingCommand.ExecuteNonQuery();

                        transaction.Commit();

                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw new Exception("Error inserting booking into Database " + e.Message);
                    }
                  
                }
            }
        }
    }
}
