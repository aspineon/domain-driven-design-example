using System.Collections.Generic;

namespace SeatReservationApp_WebAPI.MapFactories
{
    internal abstract class MappingBase
    {
        internal abstract TOutput Get<TInput, TOutput>(TInput source) 
            where TInput : class
            where TOutput : class;
    }
}