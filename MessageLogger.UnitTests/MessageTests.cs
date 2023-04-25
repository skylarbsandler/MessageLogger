namespace MessageLogger.UnitTests
{
    public class MessageTests
    {
        [Fact]
        public void Message_IsCreatedwith_CorrectPropertyValues()
        {
            Message message1 = new Message("Hello", DateTime.Now);

            Assert.Equal("Hello", message1.Content);
            Assert.IsType<DateTime>(message1.CreatedAt);
        }
    }
}