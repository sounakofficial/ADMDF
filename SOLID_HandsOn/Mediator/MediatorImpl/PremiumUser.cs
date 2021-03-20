using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorImpl
{
    internal class PremiumUser : IUser
    {
        private ChatMediator chatMediator;
        private string name;

        public PremiumUser(ChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Name: {name}; Message: {message}");
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message);
        }
    }
}