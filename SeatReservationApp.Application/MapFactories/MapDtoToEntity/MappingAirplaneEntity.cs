using System;
using System.Collections.Generic;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp.Domain.Entities;

namespace SeatReservationApp.Impl.Application.MapFactories.MapDtoToEntity
{
    internal class MappingAirplaneEntity : MappingBase
    {
        internal override TOutput Get<TInput, TOutput>(TInput source)
        {
            if (source == null) { return default(TOutput); }

            var dto = source as AirplaneDto;

            if (dto == null) { throw new InvalidCastException(typeof(TInput).Name); }

            var seatsList = new List<Seat>();
            var maxRow = 0;
            var maxColumn = 0;

            foreach (var seat in dto.Seats)
            {
                var row = Convert.ToInt32(seat.Row);
                var column = Convert.ToInt32(seat.Row);
                if (row > maxRow) maxRow = row;
                if (column > maxColumn) maxColumn = column;

                seatsList.Add(new Seat
                {
                    Row = row,
                    Column = column,
                    Available = AvailabilityEnum.Free,
                });
            }
            return new Airplane(Convert.ToInt32(dto.FlightNumber), seatsList, maxColumn, maxRow)
             as TOutput;
        }
    }
}