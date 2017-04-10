using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using SeatReservationApp.Airplanes.Domain.DomainServiceImplementations;
using SeatReservationApp.Airplanes.Domain.DomainServicesContracts;
using SeatReservationApp.Airplanes.Domain.Entities;
using SeatReservationApp.Airplanes.Domain.Repository;

namespace SeatReservationApp.Domain.UnitTest
{
    [TestClass]
    public class AssignSeatServiceSpec
    {
        private static Mock<IAirplaneRecoverService> _iAirplaneRecoverServiceMock;
        private static Mock<IAirplaneRepository> _iAirplaneRepositoryMock;
        private static AssignSeatService _assignSeatService;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
             MockFactory mockFactory = new MockFactory();
            _iAirplaneRecoverServiceMock = mockFactory.CreateMock<IAirplaneRecoverService>();
            _iAirplaneRepositoryMock = mockFactory.CreateMock<IAirplaneRepository>();
            _assignSeatService = new AssignSeatService(_iAirplaneRepositoryMock.MockObject, _iAirplaneRecoverServiceMock.MockObject);
        }

        [TestMethod]
        public void assign_seat_returns_false()
        {
            _iAirplaneRecoverServiceMock.Expects.AtLeastOne.Method(x => x.RecoverPlane(null))
                .WithAnyArguments()
                .WillReturn(new Airplane(1, new List<Seat>(), 4, 4));

            var result = _assignSeatService.AssignSeat(new Airplane(1, new List<Seat>(), 4, 4), new Seat {Row = 1, Column = 1});
            Assert.AreEqual(result, false);
        }

    }
}
