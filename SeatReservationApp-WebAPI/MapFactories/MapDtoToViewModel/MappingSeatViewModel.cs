using System;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp_WebAPI.Models;

namespace SeatReservationApp_WebAPI.MapFactories.MapDtoToViewModel
{
    internal class MappingSeatAssignViewModel : MappingBase
    {
        internal override TOutput Get<TInput, TOutput>(TInput source)
        {
            if (source == null) { return default(TOutput); }

            var dto = source as AssignSeatDto;

            if (dto == null) { throw new InvalidCastException(typeof(TInput).Name); }

            return new SeatAssignViewModel
            {
                Column = dto.Column,
                Row = dto.Column,
                FlightNumber = dto.FlightNumber
            } as TOutput;
        }
    }
}