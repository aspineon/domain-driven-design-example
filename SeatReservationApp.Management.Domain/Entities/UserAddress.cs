using System.Text.RegularExpressions;

namespace SeatReservationApp.Management.Domain.Entities
{
    public class UserAddress
    {
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        private const string RegexUsPostalCodePattern = @"^\d{5}$|^\d{5}-\d{4}$";


        public bool IsAValidPostCode()
        {
            return Regex.Match(PostalCode, RegexUsPostalCodePattern).Success;
        }

    }


}
