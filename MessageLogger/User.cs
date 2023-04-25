using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public class User
    {
        public string Name;
        public string Username;
        public List<Message> Messages;

        public User(string name, string username)
        {
            Name = name;
            Username = username;
            Messages = new List<Message>();
        }

        public void CreateUser()
        {
            Console.WriteLine("Let's create a user profile for you.");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.Write("What is your username? (one word, no spaces!) ");
            var userName = Console.ReadLine();
            var user1 = new User(name, userName);
        }

        public void LogIn(User user)
        {
            foreach(var message in Messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
