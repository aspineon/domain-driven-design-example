using System.Collections.Generic;

namespace SeatReservationApp.Domain.Entities
{
    public class Airplane
    {
        private readonly List<Seat> Seats;
        public int Id;
        public int TotalColumns;
        public int TotalRows;

        public Airplane(int id, List<Seat> seats, int totalColumns, int totalRows)
        {
            Id = id;
            Seats = seats;
            TotalColumns = totalColumns;
            TotalRows = totalRows;
        }

        public bool EnoughAvalaibleSeats(int requestNumSeats)
        {
            var freeSeats = 0;
            foreach (var seat in Seats)
            {
                if (seat.IsAvailable)
                {
                    freeSeats++;
                }
            }
            return freeSeats >= requestNumSeats;
        }

        public int AvalaibleSeats()
        {
            var freeSeats = 0;
            foreach (var seat in Seats)
            {
                if (seat.IsAvailable)
                {
                    freeSeats++;
                }
            }
            return freeSeats;
        }

        public bool AssignSeat(Seat seat)
        {
            if (IsValidSeat(seat) && Seats.Find(x => x.Column == seat.Column && x.Row == seat.Row).IsAvailable)
            {
                Seats.Find(x => x.Column == seat.Column && x.Row == seat.Row).Available = AvailabilityEnum.Booked;
                return true;
            }
            return false;
        }

        public bool UnAssignSeat(Seat seat)
        {
            if (IsValidSeat(seat))
            {
                Seats.Find(x => x.Column == seat.Column && x.Row == seat.Row).Available = AvailabilityEnum.Free;
                return true;
            }
            return false;
        }

        protected bool IsValidSeat(Seat seat)
        {
            return seat.Column <= TotalColumns && seat.Column > 0 &&
                seat.Row <= TotalRows && seat.Row > 0;
        }

    }
}
