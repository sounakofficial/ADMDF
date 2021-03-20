using System;

namespace MediatorImpl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mediator = new ChatMediator();

            var u1 = new BasicUser(mediator, "user1");
            var u2 = new BasicUser(mediator, "user2");
            var u3 = new PremiumUser(mediator, "user3");

            mediator.AddUser(u2);
            mediator.AddUser(u3);

            u1.SendMessage("Test Broadcast");
        }
    }
}