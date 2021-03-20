using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorImpl
{
    internal class BasicUser : IUser
    {
        private ChatMediator chatMediator;
        private string name;

        public BasicUser(ChatMediator chatMediator, string name)
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