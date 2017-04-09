using System;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp_WebAPI.Models;

namespace SeatReservationApp_WebAPI.MapFactories.MapViewModelToDto
{
    internal class MappingAssignSeatDto : MappingBase
    {
        internal override TOutput Get<TInput, TOutput>(TInput source)
        {
            if (source == null) { return default(TOutput); }

            var dto = source as SeatAssignViewModel;

            if (dto == null) { throw new InvalidCastException(typeof(TInput).Name); }

            return new AssignSeatDto
            {
                Column = dto.Column,
                Row = dto.Column,
                FlightNumber = dto.FlightNumber
            } as TOutput;
        }
    }
}