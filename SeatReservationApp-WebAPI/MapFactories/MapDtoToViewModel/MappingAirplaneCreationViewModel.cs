using System;
using System.Collections.Generic;
using System.Xml;
using SeatReservationApp.Contracts.Application.DTO;
using SeatReservationApp_WebAPI.Models;

namespace SeatReservationApp_WebAPI.MapFactories.MapDtoToViewModel
{
    internal class MappingAirplaneCreationViewModel : MappingBase
    {
        internal override TOutput Get<TInput, TOutput>(TInput source)
        {
            if (source == null) { return default(TOutput); }

            var dto = source as AirplaneDto;

            if (dto == null) { throw new InvalidCastException(typeof(TInput).Name); }

            var seatsList = new List<SeatsCreationViewModel>();
            foreach (var seat in dto.Seats)
            {
                seatsList.Add(new SeatsCreationViewModel
                {
                    Row = seat.Row,
                    Column = seat.Column
                });
            }

            return new AirplaneCreationViewModel
            {
               FlightNumber = Convert.ToInt32(dto.FlightNumber),
               Seats = seatsList
            } as TOutput;
        }
    }
}