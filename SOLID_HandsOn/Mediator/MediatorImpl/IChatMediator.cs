using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorImpl
{
    internal interface IChatMediator
    {
        void AddUser(IUser user);

        void SendMessage(string message);
    }
}