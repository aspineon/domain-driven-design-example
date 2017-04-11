using System;
using SeatReservationApp.Management.Infrastructure.Mappings.MapDomainToPersistence;

namespace SeatReservationApp.Management.Infrastructure.Mappings
{
    internal class MappingsFactory
    {
        internal static MappingBase GetFor(EnumMappingModel model)
        {
            switch (model)
            {
                case EnumMappingModel.ToPersistenceModel:
                    return new MappingToPersistenceModel();
                default:
                    throw new NotImplementedException(string.Format("The mapping for type {0} is not implemented.", model));
            }
        }
    }
}
