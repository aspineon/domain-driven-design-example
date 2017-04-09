using System;
using SeatReservationApp_WebAPI.MapFactories.MapDtoToViewModel;
using SeatReservationApp_WebAPI.MapFactories.MapViewModelToDto;

namespace SeatReservationApp_WebAPI.MapFactories
{
    internal class MappingsFactory
    {
        internal static MappingBase GetFor(EnumViewModel model)
        {
            switch (model)
            {
                case EnumViewModel.SeatAssignViewModel:
                    return new MappingSeatAssignViewModel();
                case EnumViewModel.AssignSeatDto:
                    return new MappingAssignSeatDto();
                case EnumViewModel.AirplaneCreationViewModel:
                    return new MappingAirplaneCreationViewModel();
                case EnumViewModel.AirplaneDto:
                    return new MappingAirplaneDto();
                default:
                    throw new NotImplementedException(string.Format("The mapping for type {0} is not implemented.", model));
            }
        }
    }
}
