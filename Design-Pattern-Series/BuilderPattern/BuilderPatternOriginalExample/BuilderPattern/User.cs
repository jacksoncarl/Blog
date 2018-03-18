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

        public User(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public User(string firstName, string lastName, Address address, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;
        }

        public User(string firstName, string lastName, Address address, DateTime dateOfBirth, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;
            Email = email;
        }

        public User(string firstName, string lastName, Address address, DateTime dateOfBirth, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public User(string firstName, string lastName, Address address, DateTime dateOfBirth, string email, string phoneNumber = "", string occupation = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;
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
