using System;
using System.Text.RegularExpressions;

namespace SeatReservationApp.Management.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserAddress Address { get; set; }
        public string Telephone { get; set; }
        private const string RegexTelephone = @"^\(\d{3}\) ?\d{3}( |-)?\d{4}|^\d{3}( |-)?\d{3}( |-)?\d{4}";

        public User() { }

        public User(int id, string firstName, string lastName, UserAddress address, string telephone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Telephone = telephone;
        }

        public bool IsValidUser()
        {
            return !String.IsNullOrEmpty(FirstName) && !String.IsNullOrEmpty(LastName) && FirstName.Length > 3 && LastName.Length > 5;
        }

        public bool IsTelephoneValid()
        {
            var match = Regex.Match(Telephone, RegexTelephone, RegexOptions.IgnoreCase);
            return match.Success;
        }

    }

}
