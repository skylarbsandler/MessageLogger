// See https://aka.ms/new-console-template for more information
using MessageLogger;
using System;

List<User> activeUsers = new List<User>();
User activeUser = null;

Console.WriteLine("Welcome to Message Logger!\n");

Console.WriteLine("Let's create a user profile for you.");
Console.Write("What is your name? ");
var name = Console.ReadLine();
Console.Write("What is your username? (one word, no spaces!) ");
var userName = Console.ReadLine();
var user1 = new User(name, userName);
activeUsers.Add(user1);
activeUser = user1;

Console.WriteLine("");
Console.WriteLine("To log out of your user profile, enter 'log out'. To quit the application, enter 'quit'");

//Console.Write("Add a message: ");

//var userMessage = new Message(Console.ReadLine(), DateTime.Now);
//user1.AddMessage(userMessage);

while (true)
{
    Console.Write("Add a message: ");
    var userMessage = new Message(Console.ReadLine(), DateTime.Now);

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
        Console.WriteLine("Would you like to log in a 'new' or 'existing' user?");
        var userInput = Console.ReadLine();

            if (userInput == "existing")
            {
                Console.Write("What is your username? ");
                userName = Console.ReadLine();
                activeUser = activeUsers.Find(user => user.Username == userName);
            }
            if (userInput == "new")
            {
                Console.WriteLine("Let's create a user profile for you.");
                Console.Write("What is your name? ");
                name = Console.ReadLine();
                Console.Write("What is your username? (one word, no spaces!) ");
                userName = Console.ReadLine();
                activeUser = new User(name, userName);
                activeUsers.Add(activeUser);
            }
    }

    else if (activeUser != null)
    {
       foreach (var message in activeUser.Messages)
       {
          Console.WriteLine($"{user1.Name} {message.CreatedAt.ToShortTimeString()}: {message.Content}");
       }

        activeUser.AddMessage(userMessage);
    }
 }




