using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeatReservationApp.Management.Domain.Entities;

namespace SeatReservationApp.Management.Domain.UnitTest
{
    [TestClass]
    public class UserAdressSpec
    {
        [TestMethod]
        public void create_a_UserAdress_with_valid_postalcode()
        {
            var user = new User(1, "John", "Dell", new UserAddress { PostalCode = "55555"}, "6581541122");
            var result = user.Address.IsAValidPostCode();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void create_a_UserAdress_with_invalid_postalcode()
        {
            var user = new User(1, "John", "Dell", new UserAddress { PostalCode = "AAA"}, "333");
            var result = user.Address.IsAValidPostCode();
            Assert.AreEqual(result, false);
        }
    }
}
