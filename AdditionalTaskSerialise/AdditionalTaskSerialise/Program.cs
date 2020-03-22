using System;
using System.Collections.Generic;

namespace AdditionalTaskSerialise
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Alex", "Diachenko");
            User user2 = new User("Serg", "Petrov");

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);

            Services.Serialiser serialiser = new Services.Serialiser();
            string test = serialiser.Serialize(users);
            Console.WriteLine(test);
            List<User> array  = serialiser.Deserialise(test) as List<User>;
            
            Console.WriteLine(array[0].ToString());
            Console.WriteLine(array[1].ToString());

            
            
            
        }
    }
}
