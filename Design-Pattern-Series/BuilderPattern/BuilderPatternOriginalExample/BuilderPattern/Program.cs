using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            User user = new User("FirstName", "LastName", DateTime.UtcNow, new Address("AddressLine1", "AddressLine2", "AddressLine3", "Town", "PostCode"), "email@email.com", "00000000");

            Console.WriteLine($"First name: {user.FirstName}");
            Console.WriteLine($"Last name: {user.LastName}");
            Console.WriteLine($"Date of birth: {user.DateOfBirth:MMMM dd, yyyy}");
            Console.ReadLine();
        }
    }
}
