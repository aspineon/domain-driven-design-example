﻿namespace SeatReservationApp.Domain.Entities
{
    public class Seat
    {
        public int Column { set; get; }
        public int Row { set;  get; }
        public AvailabilityEnum Available { set; get; }

        public bool IsAvailable => Available == AvailabilityEnum.Free;

    }


}