using System;
using SeatReservationApp.Impl.Application.MapFactories.MapDtoToEntity;

namespace SeatReservationApp.Impl.Application.MapFactories
{
    internal class MappingsFactory
    {
        internal static MappingBase GetFor(EnumViewModel model)
        {
            switch (model)
            { 
                case EnumViewModel.MappingAirplaneEntity:
                    return new MappingAirplaneEntity();
                default:
                    throw new NotImplementedException(string.Format("The mapping for type {0} is not implemented.", model));
            }
        }
    }
}
