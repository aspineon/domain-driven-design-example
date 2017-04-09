using System.Collections.Generic;
using System.Linq;

namespace SeatReservationApp.Domain.Entities
{
    public class Airplane
    {
        public List<Seat> Seats { get; set; }
        public int Id { get; set; }
        public int TotalColumns { get; set; }
        public int TotalRows { get; set; }

        protected Airplane() { }

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

        public bool CanAssignSeat(Seat seat)
        {
            if (IsValidSeat(seat) && Seats.Find(x => x.Column == seat.Column && x.Row == seat.Row).IsAvailable)
            {
                Seats.Find(x => x.Column == seat.Column && x.Row == seat.Row).Available = AvailabilityEnum.Free;
                return true;
            }
            return false;
        }

        public bool CanUnAssignSeat(Seat seat)
        {
            if (IsValidSeat(seat))
            {
                Seats.Find(x => x.Column == seat.Column && x.Row == seat.Row).Available = AvailabilityEnum.Booked;
                return true;
            }
            return false;
        }

        public bool IsValidAirplane()
        {
            return Id != null && Seats.Count > 0 && Seats.Count(x => x.Available == AvailabilityEnum.Free) > 0;
        }

        protected bool IsValidSeat(Seat seat)
        {
            return seat.Column <= TotalColumns && seat.Column > 0 &&
                seat.Row <= TotalRows && seat.Row > 0;
        }

    }
}
