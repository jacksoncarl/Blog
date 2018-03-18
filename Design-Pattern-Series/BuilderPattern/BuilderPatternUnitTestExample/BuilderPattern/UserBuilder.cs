using System;

namespace BuilderPattern
{
    public class UserBuilder
    {
        private string _firstName = "firstName";
        private string _lastName = "lastName";
        private Address _address = new Address("addressLine1", "addressLine2", "addressLine3", "town", "postcode");
        private DateTime _dateOfBirth = DateTime.UtcNow;
        private string _email = "email@test.com";
        private string _phoneNumber = "00000000000";
        private string _occupation = "software developer";

        public UserBuilder AddFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public UserBuilder AddLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public UserBuilder AddAddress(Address address)
        {
            _address = address;
            return this;
        }

        public UserBuilder AddDateOfBirth(DateTime dateTime)
        {
            _dateOfBirth = dateTime;
            return this;
        }

        public UserBuilder AddEmail(string email)
        {
            _email = email;
            return this;
        }

        public UserBuilder AddPhoneNumber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
            return this;
        }

        public UserBuilder AddOccupation(string occupation)
        {
            _occupation = occupation;
            return this;
        }

        private User Build()
        {
            return new User(_firstName, _lastName, _dateOfBirth, _email, _address, _phoneNumber, _occupation);
        }

        public static implicit operator User(UserBuilder userBuilder)
        {
            return userBuilder.Build();
        }
    }
}
