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
                case EnumViewModel.SeatViewModel:
                    return new MappingSeatViewModel();
                case EnumViewModel.SeatDto:
                    return new MappingSeatDto();
                default:
                    throw new NotImplementedException(string.Format("The mapping for type {0} is not implemented.", model));
            }
        }
    }
}
