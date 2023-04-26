// See https://aka.ms/new-console-template for more information
using MessageLogger;
using System;

List<User> activeUsers = new List<User>();
bool activeUser = false;

Console.WriteLine("Welcome to Message Logger!\n");

Console.WriteLine("Let's create a user profile for you.");
Console.Write("What is your name? ");
var name = Console.ReadLine();
Console.Write("What is your username? (one word, no spaces!) ");
var userName = Console.ReadLine();
var user1 = new User(name, userName);
activeUsers.Add(user1);
activeUser = true;

Console.WriteLine("");
Console.WriteLine("To log out of your user profile, enter 'log out'. To quit the application, enter 'quit'");

Console.Write("Add a message: ");

var userMessage = new Message(Console.ReadLine(), DateTime.Now);
user1.AddMessage(userMessage);

while (activeUser == true)
{
    if (userMessage.Content == "quit")
    {
        Console.WriteLine("");
        Console.WriteLine("Thanks for using Message Logger!");
        foreach (var user in activeUsers)
        {
            Console.WriteLine($"{user.Name} wrote {user.Messages.Count - 1} messages.");
        }
        break;
    }

    if (userMessage.Content == "log out")
    {
        activeUser = false;
        {
            Console.Write("\nWould you like to log in a 'new' or 'existing' user? ");
            userMessage.Content = Console.ReadLine();

            if (userMessage.Content == "existing")
            {
                Console.Write("What is your username? ");
                userName = Console.ReadLine();
                user1 = activeUsers.Find(user => user.Username == userName);
                activeUser = true;
            }
            if (userMessage.Content == "new")
            {
                Console.WriteLine("\nLet's create a user profile for you.");
                Console.Write("What is your name? ");
                name = Console.ReadLine();
                Console.Write("What is your username? (one word, no spaces!) ");
                userName = Console.ReadLine();
                user1 = new User(name, userName);
                activeUsers.Add(user1);
                activeUser = true;
                Console.WriteLine("\nTo log out of your user profile, enter 'log out'. To quit the application, enter 'quit'");
                Console.Write("Add a message: ");
                userMessage = new Message(Console.ReadLine(), DateTime.Now);
            }
        }
    }

    if (userMessage.Content != "log out" && userMessage.Content != "quit")
    {
       foreach (var message in user1.Messages)
       {
          Console.WriteLine($"{user1.Name} {message.CreatedAt.ToShortTimeString()}: {message.Content}");
       }

        Console.Write("Add a message: ");
        userMessage = new Message(Console.ReadLine(), DateTime.Now);

        if (userMessage.Content != "log out" && userMessage.Content != "quit")
        {
            user1.AddMessage(userMessage);
            Console.WriteLine("");
        }
    }
 }




