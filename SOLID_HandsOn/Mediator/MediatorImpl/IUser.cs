using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorImpl
{
    internal interface IUser
    {
        void ReceiveMessage(string message);

        void SendMessage(string message);
    }
}