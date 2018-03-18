using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            User user = new UserBuilder()
                .AddFirstName("carl")
                .AddDateTime(DateTime.UtcNow);

            Console.WriteLine($"First name: {user.FirstName}");
            Console.WriteLine($"Last name: {user.LastName}");
            Console.WriteLine($"Date of birth: {user.DateOfBirth:MMMM dd, yyyy}");
            Console.ReadLine();
        }
    }
}
