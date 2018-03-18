using System;

namespace BuilderPattern
{
    public class User
    {
        public User(string firstName, string lastName, DateTime dateOfBirth, string email = "", Address address = null, string phoneNumber = "", string occupation = "")
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            Occupation = occupation;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public Address Address { get; }

        public DateTime DateOfBirth { get; }

        public string Email { get; }

        public string PhoneNumber { get; set; }

        public string Occupation { get; set; }
    }
}
