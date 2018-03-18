using System;

namespace BuilderPattern
{
    public class User
    {
        public User(string firstName)
        {
            FirstName = firstName;
        }

        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User(string firstName, string lastName, Address address = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        // ...more constructors here..

        public User(string firstName, string lastName, DateTime dateOfBirth, Address address = null, string email = "", string phoneNumber = "")
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public User(string firstName, string lastName, DateTime dateOfBirth, Address address = null, string email = "", string phoneNumber = "", string occupation = "")
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            Email = email;
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