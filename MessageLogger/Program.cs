// See https://aka.ms/new-console-template for more information
using MessageLogger;
using System;

//List<User> users = new List<User>();
//var user1 = new User("Skylar", "ssandler");
//var helloMessage = new Message("hello", DateTime.Now);
//user1.Messages.Add(helloMessage);

//var user2 = new User("Scott", "sganz");
//var happyBirthday = new Message("happy birthday", DateTime.Now);
//user2.Messages.Add(happyBirthday);


Console.WriteLine("Welcome to Message Logger!");
Console.WriteLine("");
Console.WriteLine("Let's create a user profile for you.");
Console.Write("What is your name? ");
var name = Console.ReadLine();
Console.Write("What is your username? (one word, no spaces!) ");
var userName = Console.ReadLine();
var user1 = new User(name, userName);
Console.WriteLine("");
Console.WriteLine("To log out of your user profile, enter 'log out'. To quit the application, enter 'quit'");

Console.Write("Add a message: ");

var message1 = new Message(Console.ReadLine(), DateTime.Now);
user1.AddMessage(message1);
string messageString = message1.Content;

while (!messageString.Equals("quit") || !messageString.Equals("log out"))
{
    foreach (var message in user1.Messages)
    {
        Console.WriteLine($"{name} {message.CreatedAt.ToShortTimeString()}: {message.Content}");
    }
    user1.MessageCounter++;
    Console.Write("Add a message: ");
    message2 = new Message(Console.ReadLine(), DateTime.Now);
    messageString = message2.Content;
}

while (messageString == "log out")
{
    Console.WriteLine("Would you like to log in a 'new' or 'existing' user?");
    Console.ReadLine();
    if (Console.ReadLine() == "existing")
    {
        Console.WriteLine("What is your username?");
        Console.ReadLine();
    }
    if (Console.ReadLine() == "new")
    {
        Console.WriteLine("Let's create a user profile for you.");
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        Console.Write("What is your username? (one word, no spaces!) ");
        var userName = Console.ReadLine();
        var user1 = new User(name, userName);
    }
}

while (messageString == "quit")
{
    user1.MessageCounter--;
    Console.WriteLine("Thanks for using Message Logger!");
    Console.WriteLine($"{user1} wrote {user1.MessageCounter}");
    Console.WriteLine($"{user2} wrote {user2.MessageCounter}");
    break;
}

//while message is not "quit", keep going
//when message is quit, print user nad user message counter
//
