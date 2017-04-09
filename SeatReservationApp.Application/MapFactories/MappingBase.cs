namespace SeatReservationApp.Impl.Application.MapFactories
{
    internal abstract class MappingBase
    {
        internal abstract TOutput Get<TInput, TOutput>(TInput source) 
            where TInput : class
            where TOutput : class;
    }
}