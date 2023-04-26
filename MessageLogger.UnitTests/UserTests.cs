using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger.UnitTests
{
    public class UserTests
    {
        [Fact] 
        public void User_CreateUser_SuccessfullyCreatesUser()
        {
            User user1 = new User("Skylar", "ssandler");
            Assert.Equal("Skylar", user1.Name);
            Assert.Equal("ssandler", user1.Username);
        }

        [Fact]
        public void User_AddMessage_AddsMessagetoUserMessageList()
        {
            User user1 = new User("Skylar", "ssandler");
            Message message1 = new Message("Hello", DateTime.Now);

            user1.AddMessage(message1);

            Assert.Equal(message1, user1.Messages.First());
        }
    }
}
