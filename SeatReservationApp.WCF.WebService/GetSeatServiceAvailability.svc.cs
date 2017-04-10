using SeatReservationApp.Contracts.Application;
using SeatReservationApp.Contracts.Application.DTO;

namespace SeatReservationApp.WCF.WebService
{
    public class GetSeatServiceAvailability : IGetSeatServiceAvailability
    {
        private readonly ISeatAvailabilityApplicationService _seatAvailabilityApplicationService;

        public GetSeatServiceAvailability(ISeatAvailabilityApplicationService seatAvailabilityApplicationService)
        {
            _seatAvailabilityApplicationService = seatAvailabilityApplicationService;
        }
        public bool GetSeatAvailability(string Row, string Column)
        {
            var seat = new SeatDto
            {
                Row = Row,
                Column = Column
            };
            return _seatAvailabilityApplicationService.GetSeatAvailability(seat);
        }
    }
}
