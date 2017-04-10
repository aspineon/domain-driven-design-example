using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeatReservationApp.Management.Domain.Entities;

namespace SeatReservationApp.Management.Domain.UnitTest
{
    [TestClass]
    public class UserSpec
    {
        [TestMethod]
        public void create_a_user_with_valid_telephone()
        {
            var user = new User(1, "John", "Dell", new UserAddress(), "6581541122");
            var result = user.IsTelephoneValid();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void create_a_user_with_invalid_telephone()
        {
            var user = new User(1, "John", "Dell", new UserAddress(), "333");
            var result = user.IsTelephoneValid();
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void create_a_user_with_valid_name()
        {
            var user = new User(1, "John", "Dellos", new UserAddress(), "6581541122");
            var result = user.IsValidUser();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void create_a_user_with_invalid_name()
        {
            var user = new User(1, "John", "Dell", new UserAddress(), "6581541122");
            var result = user.IsValidUser();
            Assert.AreEqual(result, false);
        }
    }
}
