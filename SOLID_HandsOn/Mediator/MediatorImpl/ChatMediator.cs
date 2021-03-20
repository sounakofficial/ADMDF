using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorImpl
{
    internal class ChatMediator : IChatMediator
    {
        private List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message)
        {
            foreach (var user in users)
            {
                user.ReceiveMessage(message);
            }
        }
    }
}