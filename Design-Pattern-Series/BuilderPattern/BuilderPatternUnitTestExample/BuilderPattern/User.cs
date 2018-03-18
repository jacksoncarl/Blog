using System;

namespace BuilderPattern
{
    public class User
    {
        public User(string firstName, string lastName, DateTime dateOfBirth, Address address, string email, string phoneNumber, string occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            UserAddress = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Occupation = occupation;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public Address UserAddress { get; }

        public DateTime DateOfBirth { get; }

        public string Email { get; }

        public string PhoneNumber { get; set; }

        public string Occupation { get; set; }
    }
}
