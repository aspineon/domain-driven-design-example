using System;
using System.Collections.Generic;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp_WebAPI.Models;

namespace SeatReservationApp_WebAPI.MapFactories.MapViewModelToDto
{
    internal class MappingAirplaneDto : MappingBase
    {
        internal override TOutput Get<TInput, TOutput>(TInput source)
        {
            if (source == null) { return default(TOutput); }

            var dto = source as AirplaneCreationViewModel;

            if (dto == null) { throw new InvalidCastException(typeof(TInput).Name); }

            var seatsList = new List<SeatDto>();
            foreach (var seat in dto.Seats)
            {
                seatsList.Add(new SeatDto
                {
                    Row = seat.Row,
                    Column = seat.Column
                });
            }

            return new AirplaneDto
            {
                FlightNumber = dto.FlightNumber.ToString(),
                Seats = seatsList
            } as TOutput;
        }
    }
}